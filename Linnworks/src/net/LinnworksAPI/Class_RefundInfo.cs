using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class RefundInfo
{ public Guid pkRefundRowId;
public String SKU;
public String ItemTitle;
public Boolean IsItem;
public Boolean IsService;
public Double Amount;
public String Reason;
public Boolean Actioned;
public DateTime ActionDate;
public String ReturnReference;
public Double Cost;
public RefundStatus RefundStatus;
public Boolean IgnoredValidation;
public Guid fkOrderItemRowId;
public Boolean ShouldSerializeChannelReason;
public String ChannelReason;
public Boolean ShouldSerializeChannelReasonSec;
public String ChannelReasonSec;
public Boolean IsNew;
 
} 
}