﻿namespace HouseRentingSystem.Core.Constants
{
    public static class MessageConstants
    {
        public const string RequiredMessage = "The field {0} is required.";

        public const string PhoneNumberErrorMessage = "The {0} field must be between {2} and {1} characters long.";

        public const string PhoneNumberExists = "The phone number already exists. Enter a different phone number";

        public const string HasRents = "You should not have any rents to become an agent.";
    }
}
