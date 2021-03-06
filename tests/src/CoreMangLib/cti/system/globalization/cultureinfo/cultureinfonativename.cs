using System;
using System.Globalization;
/// <summary>
///NativeName
/// </summary>
public class CultureInfoNativeName
{
    public static int Main()
    {
        CultureInfoNativeName CultureInfoNativeName = new CultureInfoNativeName();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoNativeName");
        if (CultureInfoNativeName.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: CultureTypes.CurrentCulture");
        try
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            {
                string inFactName = ci.NativeName;
                string excepectedName = new CultureInfo(ci.Name).NativeName;
                if (excepectedName != inFactName)
                {
                    TestLibrary.TestFramework.LogError("001", "the fact NativeName is different from  excepectedName which  comes from LCID");
                    retVal = false;
                }
            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }

   
}

