﻿namespace Programming.Model
{
    using System;

    public class Validator
    {
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
            }
        }

        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
            }
        }
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }

        public static void AssertValueInRange(string nameProperty, double value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }

        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }
        public static void AssertStringContainsOnlyLetters(string value, string nameProperty)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException(
                        $"the value of the {nameProperty} field should consist only of English letters.");
                }
            }
        }
    }

}