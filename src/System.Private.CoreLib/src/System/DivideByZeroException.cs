// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*=============================================================================
**
**
**
** Purpose: Exception class for bad arithmetic conditions!
**
**
=============================================================================*/

namespace System
{
    public class DivideByZeroException : ArithmeticException
    {
        public DivideByZeroException()
            : base(SR.Arg_DivideByZero)
        {
            SetErrorCode(__HResults.COR_E_DIVIDEBYZERO);
        }

        public DivideByZeroException(String message)
            : base(message)
        {
            SetErrorCode(__HResults.COR_E_DIVIDEBYZERO);
        }

        public DivideByZeroException(String message, Exception innerException)
            : base(message, innerException)
        {
            SetErrorCode(__HResults.COR_E_DIVIDEBYZERO);
        }
    }
}
