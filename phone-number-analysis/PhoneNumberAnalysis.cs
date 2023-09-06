using System;
using System.Text.RegularExpressions;

public static class PhoneNumber
{

    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        // Define constants for indices and values
        const int AreaCodeStartIndex = 0;
        const int AreaCodeLength = 3;
        const int ExchangeStartIndex = 4;
        const int ExchangeLength = 3;
        const int LocalNumberStartIndex = 8;
        const int LocalNumberLength = 4;
        const string NewYorkAreaCode = "212";
        const string FakeExchange = "555";

        // Input validation using a regular expression
        if (!Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$"))
        {
            throw new ArgumentException("Invalid phone number format. It should be in the format '123-123-1234'.", nameof(phoneNumber));
        }

        // Extract components
        string areaCode = phoneNumber.Substring(AreaCodeStartIndex, AreaCodeLength);
        string exchange = phoneNumber.Substring(ExchangeStartIndex, ExchangeLength);
        string localNumber = phoneNumber.Substring(LocalNumberStartIndex, LocalNumberLength);

        // Initialize result tuple
        (bool IsNewYork, bool IsFake, string LocalNumber) result = (false, false, localNumber);

        // Check if the area code is 212
        if (areaCode == NewYorkAreaCode)
        {
            result.IsNewYork = true;
        }

        // Check if the exchange is 555
        if (exchange == FakeExchange)
        {
            result.IsFake = true;
        }

        return result;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
