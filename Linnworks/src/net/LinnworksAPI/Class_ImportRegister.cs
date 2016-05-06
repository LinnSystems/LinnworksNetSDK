using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class ImportRegister
{ public String LastFileChecksum;
public String ImportStatus;
public Boolean ImportSkipped;
public Int32 Id;
public ImportType Type;
public String FriendlyName;
public Boolean Executing;
public Boolean justOnce;
public DateTime Started;
public DateTime Completed;
public Boolean IsQueued;
public Boolean Enabled;
public Boolean IsNew;
public Boolean AllSchedulesDisabled;
public DateTime NextSchedule;
 
} 
}