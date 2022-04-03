using System;
using PX.Data;
using PX.Data.BQL.Fluent;

namespace AccountHierarchy
{
  [PXCacheName("xReportClass")]
  public class xReportClass : IBqlTable
  {
    #region XReportClassID
    [PXDBIdentity]
    public virtual int? XReportClassID { get; set; }
    public abstract class xReportClassID : PX.Data.BQL.BqlInt.Field<xReportClassID> { }
    #endregion

    #region XReportClassCD
    [PXDBString(30, IsKey = true, IsUnicode = true, InputMask = "")]
    [PXDefault]
    [PXUIField(DisplayName = "Report Class ID")]
    [PXSelector(typeof(Search<xReportClass.xReportClassCD>),
                typeof(xReportClass.xReportClassCD),
                typeof(xReportClass.description))]  
    public virtual string XReportClassCD { get; set; }
    public abstract class xReportClassCD : PX.Data.BQL.BqlString.Field<xReportClassCD> { }
    #endregion

    #region ParentReportClassID
    [PXDBInt()]
    [PXUIField(DisplayName = "Parent ID")]
    [PXParent(typeof(SelectFrom<xReportClass>.Where<xReportClass.xReportClassID.IsEqual<xReportClass.parentReportClassID.FromCurrent>>))]
    [PXSelector(
                typeof(Search<xReportClass.xReportClassID>),
                typeof(xReportClass.description),
      //DescriptionField = typeof(xReportClass.description),
                SubstituteKey = typeof(xReportClass.description)
                )]
    public virtual int? ParentReportClassID { get; set; }
    public abstract class parentReportClassID : PX.Data.BQL.BqlInt.Field<parentReportClassID> { }
    #endregion

    /*
    #region ParentReportClassID
    [PXDBInt()]
    [PXUIField(DisplayName = "Parent ID")]
    [PXParent(typeof(SelectFrom<xReportClass>.Where<xReportClass.id.IsEqual<xReportClass.parentReportClassID.FromCurrent>>))] //ссылка на родителя
    [PXSelector(
                typeof(Search<xReportClass.id>),
      typeof(xReportClass.description),
      //DescriptionField = typeof(xReportClass.description),
      SubstituteKey = typeof(xReportClass.description)
                )]
    public virtual int? ParentReportClassID { get; set; }
    public abstract class parentReportClassID : PX.Data.BQL.BqlInt.Field<parentReportClassID> { }
    #endregion
    */  
      
    #region Description
    [PXDBString(50, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Description")]
    public virtual string Description { get; set; }
    public abstract class description : PX.Data.BQL.BqlString.Field<description> { }
    #endregion


    #region RepairItemLineCntr
    [PXDBInt()]
    [PXDefault(0)]
    public virtual Int32? RepairItemLineCntr { get; set; }
    public abstract class repairItemLineCntr : PX.Data.BQL.BqlInt.Field<repairItemLineCntr> { }
    #endregion
    
    #region CreatedDateTime
    [PXDBCreatedDateTime()]
    public virtual DateTime? CreatedDateTime { get; set; }
    public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime> { }
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

    #region LastModifiedDateTime
    [PXDBLastModifiedDateTime()]
    public virtual DateTime? LastModifiedDateTime { get; set; }
    public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> { }
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

    #region Tstamp
    [PXDBTimestamp()]
    public virtual byte[] Tstamp { get; set; }
    public abstract class tstamp : PX.Data.BQL.BqlByteArray.Field<tstamp> { }
    #endregion

    #region Noteid
    [PXNote()]
    public virtual Guid? NoteID { get; set; }
    public abstract class noteID : PX.Data.BQL.BqlGuid.Field<noteID> { }
    #endregion
  }
}