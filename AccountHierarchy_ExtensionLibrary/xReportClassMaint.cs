using System;
using PX.Data;
using PX.Data.BQL.Fluent;
using PX.Objects.GL;


namespace AccountHierarchy
{
  public class xReportClassMaint : PXGraph<xReportClassMaint, xReportClass>
  {

    //public PXSave<xReportClass> Save;
   // public PXCancel<xReportClass> Cancel;

    public SelectFrom<xReportClass>.View xReportClassView;
    //public SelectFrom<xReportClassDet>.Where<xReportClassDet.xReportClassID.IsEqual<xReportClass.xReportClassID.FromCurrent>>.View ReportClassDetails;
    //public SelectFrom<Account>.Where<Account.accountID.IsEqual<xReportClassDet.accountID.FromCurrent>>.View AccoutClassView;
    
  
    public SelectFrom<xReportClassDet>.
     LeftJoin<Account>.On<Account.accountID.IsEqual<xReportClassDet.accountID>>.
     Where<xReportClassDet.xReportClassID.IsEqual<xReportClass.xReportClassID.FromCurrent>>.View ReportClassDetails;
  
  /*
  SelectFrom<FSServiceOrder>.
 InnerJoin<FSAppointment>.On<FSAppointment.soRefNbr.IsEqual<FSServiceOrder.refNbr>>.
 InnerJoin<FSWFStage>.On<FSWFStage.wFStageID.IsEqual<FSAppointment.wFStageID>>.
 InnerJoin<FSRoom>.On<FSRoom.roomID.IsEqual<FSServiceOrder.roomID>>.
 InnerJoin<FSEquipment>.On<FSEquipment.registrationNbr.IsEqual<FSRoom.descr>>.
 Where<FSServiceOrder.srvOrdType.IsEqual<P.AsString>.
     And<FSWFStage.wFStageCD.IsEqual<P.AsString>>>.
  */
  /*
    public PXFilter<MasterTable> MasterView;
    public PXFilter<DetailsTable> DetailsView;

    [Serializable]
    public class MasterTable : IBqlTable
    {

    }

    [Serializable]
    public class DetailsTable : IBqlTable
    {

    }
    */

  }
}