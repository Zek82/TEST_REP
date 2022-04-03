using System;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.IN;
using PX.Objects.GL;

namespace AccountHierarchy
{
 
  [PXCacheName("xReportClassDet")]
  public class xReportClassDet : IBqlTable
  {
    #region XReportClassID
    [PXDBInt]
    //[PXUIField(DisplayName = "X Report Class ID")]
    [PXDBDefault(typeof(xReportClass.xReportClassID))]
    [PXParent(typeof(SelectFrom<xReportClass>.Where<xReportClass.xReportClassID.IsEqual<xReportClassDet.xReportClassID.FromCurrent>>))]
    public virtual int? XReportClassID { get; set; }
    public abstract class xReportClassID : PX.Data.BQL.BqlInt.Field<xReportClassID> { }
    #endregion

    #region AccountID
    [PXDBInt(IsKey = true)]
    [PXUIField(DisplayName = "Account ID")]
        [PXSelector(typeof(Search<Account.accountID>),
                typeof(Account.accountCD),
               // typeof(Account.description),
                SubstituteKey = typeof(Account.accountCD),
                DescriptionField = typeof(Account.description)
                )]
    public virtual int? AccountID { get; set; }
    public abstract class accountID : PX.Data.BQL.BqlInt.Field<accountID> { }
    #endregion

    #region LineNbr
    [PXDBInt(IsKey = true)]
    [PXLineNbr(typeof(xReportClass.repairItemLineCntr))]
    [PXUIField(DisplayName = "Line Nbr", Visible = false)]
    public virtual int? LineNbr { get; set; }
    public abstract class lineNbr : PX.Data.BQL.BqlInt.Field<lineNbr> { }
    #endregion

    #region CreatedByID
    [PXDBCreatedByID()]
    public virtual Guid? CreatedByID { get; set; }
    public abstract class createdByID : PX.Data.BQL.BqlGuid.Field<createdByID> { }
    #endregion

    #region CreatedByScreenID
    [PXDBCreatedByScreenID()]
    public virtual string CreatedByScreenID { get; set; }
    public abstract class createdByScreenID : PX.Data.BQL.BqlString.Field<createdByScreenID> { }
    #endregion

    #region CreatedDateTime
    [PXDBCreatedDateTime()]
    public virtual DateTime? CreatedDateTime { get; set; }
    public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime> { }
    #endregion

    #region LastModifiedByID
    [PXDBLastModifiedByID()]
    public virtual Guid? LastModifiedByID { get; set; }
    public abstract class lastModifiedByID : PX.Data.BQL.BqlGuid.Field<lastModifiedByID> { }
    #endregion

    #region LastModifiedByScreenID
    [PXDBLastModifiedByScreenID()]
    public virtual string LastModifiedByScreenID { get; set; }
    public abstract class lastModifiedByScreenID : PX.Data.BQL.BqlString.Field<lastModifiedByScreenID> { }
    #endregion

    #region LastModifiedDateTime
    [PXDBLastModifiedDateTime()]
    public virtual DateTime? LastModifiedDateTime { get; set; }
    public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> { }
    #endregion

    #region Tstamp
    [PXDBTimestamp()]
    [PXUIField(DisplayName = "Tstamp")]
    public virtual byte[] Tstamp { get; set; }
    public abstract class tstamp : PX.Data.BQL.BqlByteArray.Field<tstamp> { }
    #endregion

    #region Noteid
    [PXNote()]
    public virtual Guid? Noteid { get; set; }
    public abstract class noteid : PX.Data.BQL.BqlGuid.Field<noteid> { }
    #endregion
  }
}