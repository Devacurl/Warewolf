using System.Collections.Generic;
using Dev2.Common.Interfaces.Diagnostics.Debug;

namespace Dev2.Common
{
    public class TestSaveResult
    {
        public SaveResult Result { get; set; }
        public string Message { get; set; } 
    }

    public class TestRunResult
    {
        public string TestName { get; set; }
        public RunResult Result { get; set; }
        public string Message { get; set; }
        public IList<IDebugState> DebugForTest { get; set; }
    }

    public enum RunResult
    {
        TestPassed,
        TestFailed,
        TestInvalid,
        TestResourceDeleted,
        TestResourcePathUpdated
    }
}