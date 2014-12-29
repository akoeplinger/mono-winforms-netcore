using System;

namespace System.ComponentModel
{
    public class PasswordPropertyTextAttribute : Attribute
    {
        public static PasswordPropertyTextAttribute Yes = new PasswordPropertyTextAttribute();
    }
}