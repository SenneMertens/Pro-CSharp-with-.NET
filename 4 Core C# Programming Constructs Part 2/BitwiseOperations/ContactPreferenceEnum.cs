using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperations;
// The Flags attribute allows multiple values from an enumeration to be combined into a single variable.
[Flags]
public enum ContactPreferenceEnum
{
    None = 1,
    Email = 2,
    Phone = 4,
    Text = 8
}
