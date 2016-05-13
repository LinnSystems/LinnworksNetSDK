using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class RefundItem
{ public Guid? pkRefundRowId;
public Boolean IsManualRefund;
public RefundItemType Type;
public Guid? fkOrderItemId;
public Int32 RefundQty;
public Double RefundAmount;
public String Reason;
public String ChannelReason;
public String ChannelReasonSec;
 
} 
}