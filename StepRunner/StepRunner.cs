using NUnit.Framework;
using StepRunner.Constants;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StepRunner
{
    public class StepRunner
    {
        private readonly IList<StepModel> testSteps = new List<StepModel>() { };
        private int stepCount = 0;
        private bool stepContinuation = false;
        //private readonly ILogService _log;  // TODO: add this and change all console writelines to use _log.Info instead

        public static StepRunner Instance { get; set; }
        public TestContext TestContext { get; set; }
        public string TestIdentifier { get; set; }
        public string TestDescription { get; set; }
        public string Environment { get; set; }
        public Status Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duration { get; set; }
        public Exception TestException { get; set; }


        private StepRunner(TestContext testContext)
        {
            TestContext = testContext;
            TestIdentifier = TestContext.CurrentContext.Test.Name;
            TestDescription = TestContext.CurrentContext.Test.ClassName;
            Status = Status.Ready;
        }
       

        public void SetExternalException(Exception ex)
        {
            Status = Status.Failed;
            TestException = ex;
        }

        public static void Initialize(TestContext testContext)
        {
            Instance = new StepRunner(testContext);
        }

        public void ClearStepResults()
        {
            testSteps.Clear();
        }

        public Status RunStep(Action action, StepModel step)
        {
            try
            {
                if (!_VerifyStepExecution(step))
                {
                    action();
                    step.Status = Status.Passed;
                }
            }
            catch (Exception ex)
            {
                _HandleException(ex, step);
            }
            finally
            {
                _FinalizeStep(step);
            }
            return step.Status;
        }

        public Status RunStep<T>(Action<T> action, T parameter, StepModel step)
        {
            try
            {
                if (!_VerifyStepExecution(step))
                {
                    action(parameter);
                    step.Status = Status.Passed;
                }
            }
            catch (Exception ex)
            {
                _HandleException(ex, step);
            }
            finally
            {
                _FinalizeStep(step);
            }
            return step.Status;
        }

        public Status RunStep<T>(Action<T, T> action, T parameter1, T parameter2, StepModel step)
        {
            try
            {
                if (!_VerifyStepExecution(step))
                {
                    action(parameter1, parameter2);
                    step.Status = Status.Passed;
                }
            }
            catch (Exception ex)
            {
                _HandleException(ex, step);
            }
            finally
            {
                _FinalizeStep(step);
            }
            return step.Status;
        }

        public void Close()
        {
            _IsFailedStep(testSteps, out Status testStatusIn);
            _IsTestFailedOutsideStep(out Status testStatusOut);
            if (testStatusIn == Status.Passed && testStatusOut == Status.Passed)
            {
                Status = Status.Passed;
            }
            else
            {
                Status = Status.Failed;
            }

            EndTime = DateTime.Now;

            TimeSpan diff = EndTime - StartTime;
            Console.WriteLine("********************************************************************************");
            Console.WriteLine($"** Test Iteration Duration: {diff}");
            Console.WriteLine($"** Test Iteration Status: {Status}");
            Console.WriteLine("********************************************************************************");

            if (StepRunner.Instance.TestException != null)
            {
                Console.WriteLine($"Exception Message: {TestException.Message}");
                Console.WriteLine($"Inner Exception: {TestException.InnerException}");
                Console.WriteLine($"Exception Stack Trace: {TestException.StackTrace}");
                Console.WriteLine("");
            }

            if (TestContext != null)
            {
                TestContext = null;
            }

            if (Instance != null)
            {
                Instance = null;
            }

            if (Status != Status.Passed)
            {
                if (TestException != null)
                {
                    throw TestException;
                }
                throw new Exception($"Test Iteration failed {TestIdentifier}");
            }
        }

        public bool ValidateIfTestIsFailed()
        {
            if (testSteps.Where(x => x.Status == Status.Failed).Count() > 0)
            {
                return true;
            }
            return false;
        }

        private bool _VerifyStepExecution(StepModel step)
        {
            bool skip = false;
            if (stepCount == 0)
            {
                StartTime = DateTime.Now;
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("** [Test Iteration]");
                Console.WriteLine($"** Iteration Name: {TestIdentifier}");
                Console.WriteLine($"** Iteration Description: {TestDescription}");
                Console.WriteLine("********************************************************************************");
            }

            stepCount++;

            step.StartTime = DateTime.Now;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"-- Step number: {stepCount}");
            Console.WriteLine($"-- Description: {step.Description}");
            Console.WriteLine($"-- Step Start Time: {step.StartTime.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture)}");
            Console.WriteLine("--------------------------------------------------------------------------------");


            if (step.SkipStep)
            {
                Console.WriteLine("-- Test status: Skipping step execution!");
                skip = true;
            }
            else if (_HasContinuationOnFailure(step))
            {
                skip = false;
            }
            else if (_IsFailedStep(testSteps, out Status testStatus) && !step.SkipStepOnFailure)
            {
                Console.WriteLine($"Test status: [{testStatus}]. Skipping step execution!");
                skip = true;
            }
            return skip;
        }

        private void _FinalizeStep(StepModel step)
        {
            testSteps.Add(step);

            step.EndTime = DateTime.Now;

            TimeSpan diff = step.EndTime - step.StartTime;

            Console.WriteLine("--------------------------------------------------------------------------------");
            if (step.Status == Status.Failed)
            {
                Console.WriteLine($"-- Step Status: {step.Status}");
                Console.WriteLine($"-- Impact Level: {step.Level}");
            }
            else
            {
                Console.WriteLine($"-- Step Status: {step.Status}");
            }

            Console.WriteLine($"-- Step Duration: {diff}");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("");
        }

        private void _HandleException(Exception ex, StepModel step)
        {
            if (step.SkipStepOnFailure)
            {
                step.Status = Status.Skipped;
            }
            else
            {
                step.Status = Status.Failed;
                step.StepException = ex;
                Console.WriteLine("Exception on step: " + step.Description, step.StepException);
                Console.WriteLine($"Message: {step.StepException.Message}");
                Console.WriteLine($"Inner Exception: {step.StepException.InnerException}");
                Console.WriteLine($"Stack Trace: {step.StepException.StackTrace}");
                Console.WriteLine("");
                TestException = ex;
            }
            stepContinuation = step.SkipStepOnFailure;
        }

        private bool _IsFailedStep(IList<StepModel> stepCollection, out Status testStatus)
        {
            if (stepCollection.Where(x => x.Status == Status.Failed).Count() > 0)
            {
                testStatus = Status.Failed;
                return true;
            }
            testStatus = Status.Passed;
            return false;
        }

        private bool _IsTestFailedOutsideStep(out Status testStatus)
        {
            if (TestException != null)
            {
                testStatus = Status.Failed;
                return true;
            }

            testStatus = Status.Passed;
            return false;
        }

        private bool _HasContinuationOnFailure(StepModel step)
        {
            if (step.SkipStepOnFailure)
            {
                return stepContinuation = true;
            }
            else if (!step.SkipStepOnFailure && stepContinuation)
            {
                return true;
            }
            return false;
        }
    }

}
