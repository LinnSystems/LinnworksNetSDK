using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class Country
{ public Guid CountryId;
public String CountryName;
public String CountryCode;
public String Continent;
public String Currency;
public Boolean CustomsRequired;
public Double? TaxRate;
public String AddressFormat;
public List<CountryRegion> Regions;
 
} 
}