using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class BaseSession
{ public DateTime LastActivity;
public DataCache Cache;
public String Server;
public StatusDetails Status;
public String Email;
public Guid Id;
public string Token;
public String GroupName;
public LocalityType Locality;
public Dictionary<String,String> Properties;
 
} 
}