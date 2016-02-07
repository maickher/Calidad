using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    class ValidateSQL
    {
        private const string DUPLICATE = "This record is already in the system.";
        private const string CANNOT_DELETE_OR_UPDATE = "There are records associated to this record.";
        private const string FOREIGNKEY_INSERT = "Cannot insert because the record contains associated data that has not been previously entered.";
        private const string FOREIGNKEY_DELETE = "Cannot delete because the record contains associated data that must be deleted before this action.";
        public static string ValidateException(string pMessage)
        {
            if (pMessage.ToUpper().Contains("DUPLICATE ENTRY"))
            {
                return DUPLICATE;
            }
            else
            {
                if (pMessage.ToUpper().Contains("CANNOT DELETE OR UPDATE A PARENT ROW"))
                {
                    return CANNOT_DELETE_OR_UPDATE;
                }
                else
                {
                    if (pMessage.ToUpper().Contains("FOREIGN KEY"))
                    {
                        if (pMessage.ToUpper().Contains("ADD"))
                        {
                            return FOREIGNKEY_INSERT;
                        }
                        else
                        {
                            return FOREIGNKEY_DELETE;
                        }
                    }
                    else
                    {
                        return "Error not handled" + "\n" +
                              "Please contact the System Administrator." + pMessage;
                    }
                }
            }
        }
    }
}
