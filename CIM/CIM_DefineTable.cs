using System;
using System.Collections.Generic;
using System.Text;

namespace CIM
{
    public class CCCIM_HandshakeBitBCForAll
    {
        public const string CIMStatus = "B0000";
    }

    public class CCCIM_HandshakeBitBCForUnit1
    {
        public const string GlassRemoveReportReply = "B0010";
        public const string GlassIDReportReply = "B0011";
        public const string MissmatchGlassInformationExist = "B0012";
        public const string MissmatchGlassInformationNone = "B0013";
    }

    public class CCCIM_HandshakeBitBCForUnit2
    {
        public const string GlassRemoveReportReply = "B0020";
        public const string GlassIDReportReply = "B0021";
        public const string MissmatchGlassInformationExist = "B0022";
        public const string MissmatchGlassInformationNone = "B0023";
    }

    public class CCCIM_HandshakeBitLoaderForAll
    {
        public const string InlineStatus = "B0040";
        public const string AutoOperationStatus = "B0041";
        public const string HeavyAlarmStatus = "B0042";
        public const string LightAlarmStatus = "B0043";
        public const string RecipeModificationOKReply = "B0044";
        public const string RecipeModificationNGReply = "B0045";
        public const string OperatorCallClear = "B0046";
        public const string ModifiedRecipeReport = "B0047";
        public const string GlassRemoveReport = "B0048";
        public const string GlassTakeoutReport = "B0049";
        public const string GlassStorageReport = "B004A";
        public const string PortPauseStatus = "B004B";
        public const string Glassloadingmovement = "B004C";
        public const string Glassunloadingmovement = "B004D";
        public const string SupplyEnd = "B004E";
        public const string GlassInformationRequest = "B004F";
    }

    public class CCCIM_HandshakeBitLoaderForUnit1
    {
        public const string LoadReady = "B0050";
        public const string LoadComplete = "B0051";
        public const string LoadCancel = "B0052";
        public const string AutoOperationStatus = "B0053";
        public const string UnloadReady = "B0054";
        public const string UnloadComplete = "B0055";
        public const string UnloadCancel = "B0056";
        public const string ExchangeReady = "B0057";
        public const string Delivering = "B0058";
        public const string Robotinterferenceoutside = "B0059";
        public const string RecipeChangeRequest = "B005A";
        public const string ExchangeComplete = "B005B";
        public const string ExchangeCancel = "B005C";
    }

    public class CCCIM_HandshakeWordLoaderForUnit1
    {
        public const string LoadGlassData_2 = "W0550";              // 2 Word
        public const string BatchID_8 = "W0552";                    // 8 Word
        public const string BatchType_8 = "W055A";                  // 8 Word
        public const string LotID_12 = "W0562";                     //12 Word
        public const string LotType_8 = "W056E";                    // 8 Word
        public const string GlassID_9 = "W0576";                    // 9 Word
        public const string ProductID_8 = "W0587";                  // 8 Word
        public const string PlanID_16 = "W058F";                    //16 Word
        public const string StepID_16 = "W059F";                    //16 Word
        public const string StepNo_4 = "W05AF";                     // 4 Word
        public const string RecipeID_9 = "W05B3";                   // 9 Word
        public const string PPID_8 = "W05BC";                       // 8 Word
        public const string AbnormalFlag_9 = "W05C4";               // 9 Word
        public const string FinalJudge_2 = "W05CD";                 // 2 Word
        public const string Grade_2 = "W05CF";                      // 2 Word
        public const string GradeCode_4 = "W05D1";                  // 4 Word
        public const string CelRepCount_1 = "W05D5";                // 1 Word
        public const string CelTrimCount_1 = "W05D6";               // 1 Word
        public const string ParCount_1 = "W05D7";                   // 1 Word
        public const string ModelName_50 = "W05DC";                 //50 Word
        public const string EQID_5 = "W060E";                       // 5 Word
        public const string VCRFlag_1 = "W0616";                    // 1 Word
        public const string LotSubType_2 = "W05D7";                 // 2 Word
        public const string ArrayGlassID_9 = "W0619";               // 9 Word
        public const string CFGlassID_9 = "W0622";                  // 9 Word
        public const string ProcessPortNo_1 = "W062B";              // 1 Word
        public const string CassetteID_12 = "W062C";                //12 Word
        public const string SlotID_2 = "W0638";                     // 2 Word
    }

    public class CCCIM_HandshakeBitLoaderForUnit2
    {
        public const string LoadReady = "B0070";
        public const string LoadComplete = "B0071";
        public const string LoadCancel = "B0072";
        public const string AutoOperationStatus = "B0073";
        public const string UnloadReady = "B0074";
        public const string UnloadComplete = "B0075";
        public const string UnloadCancel = "B0076";
        public const string ExchangeReady = "B0077";
        public const string Delivering = "B0078";
        public const string Robotinterferenceoutside = "B0079";
        public const string RecipeChangeRequest = "B007A";
        public const string ExchangeComplete = "B007B";
        public const string ExchangeCancel = "B007C";
    }

    public class CCCIM_HandshakeWordLoaderForUnit2
    {
        public const string LoadGlassData_2 = "W0670";              // 2 Word
        public const string BatchID_8 = "W0672";                    // 8 Word
        public const string BatchType_8 = "W067A";                  // 8 Word
        public const string LotID_12 = "W0682";                     //12 Word
        public const string LotType_8 = "W068E";                    // 8 Word
        public const string GlassID_9 = "W0696";                    // 9 Word
        public const string ProductID_8 = "W06A7";                  // 8 Word
        public const string PlanID_16 = "W06AF";                    //16 Word
        public const string StepID_16 = "W06BF";                    //16 Word
        public const string StepNo_4 = "W06CF";                     // 4 Word
        public const string RecipeID_9 = "W06D3";                   // 9 Word
        public const string PPID_8 = "W06DC";                       // 8 Word
        public const string AbnormalFlag_9 = "W06E4";               // 9 Word
        public const string FinalJudge_2 = "W06ED";                 // 2 Word
        public const string Grade_2 = "W06EF";                      // 2 Word
        public const string GradeCode_4 = "W06F1";                  // 4 Word
        public const string CelRepCount_1 = "W06F5";                // 1 Word
        public const string CelTrimCount_1 = "W06F6";               // 1 Word
        public const string ParCount_1 = "W06F7";                   // 1 Word
        public const string ModelName_50 = "W06FC";                 //50 Word
        public const string EQID_5 = "W072E";                       // 5 Word
        public const string VCRFlag_1 = "W0736";                    // 1 Word
        public const string LotSubType_2 = "W0737";                 // 2 Word
        public const string ArrayGlassID_9 = "W0739";               // 9 Word
        public const string CFGlassID_9 = "W0742";                  // 9 Word
        public const string ProcessPortNo_1 = "W074B";              // 1 Word
        public const string CassetteID_12 = "W074C";                //12 Word
        public const string SlotID_2 = "W0758";                     // 2 Word
    }

    public class CCCIM_HandshakeBitEQUnit1
    {
        public const string InlineStatus = "B0100";
        public const string AutoOperationStatus = "B0101";
        public const string HeavyAlarmStatus = "B0102";
        public const string LightAlarmStatus = "B0103";
        public const string GlassRemoveReport = "B0104";
        public const string GlassIDReport = "B0105";
        public const string RecipeChangeAcceptance = "B0106";
        public const string MissmatchGlassInformationRequest = "B0107";
        
        public const string LoadRequest = "B0110";
        public const string LoadOK = "B0111";
        public const string ExchangeRequest = "B0112";
        
        public const string UnloadRequest = "B0114";
        public const string UnloadOK = "B0115";
        public const string ExchangeOK = "B0116";
        
        public const string DeliveryPauseRequest = "B0118";
        public const string DeliveryCancelRequest = "B0119";
        public const string RecipeChangeReply = "B011A";
        public const string RoboPenetrationpermission = "B011B";
    }

    public class CCCIM_HandshakeWordEQUnit1
    {
        public const string GlassID_9 = "W0820";
        public const string PPID_8 = "W0829";
        public const string LotID_12 = "W0831";
        public const string StepID_16 = "W083D";
        public const string CelRepCount_1 = "W084D";
        public const string EQID_5 = "W084E";
        public const string CellTestCSTID_4 = "W0853";
        public const string CollectFlag_2 = "W085C";
        public const string Grade_2 = "W085E";
        public const string GradeCode_4 = "W0860";
        public const string MAXPower_4 = "W0864";
        public const string MINPower_4 = "W0868";
        public const string AVGPower_4 = "W086C";
        public const string STDPower_4 = "W0870";
    }

    public class CCCIM_HandshakeBitEQUnit2
    {
        public const string InlineStatus = "B0140";
        public const string AutoOperationStatus = "B0141";
        public const string HeavyAlarmStatus = "B0142";
        public const string LightAlarmStatus = "B0143";
        public const string GlassRemoveReport = "B0144";
        public const string GlassIDReport = "B0145";
        public const string RecipeChangeAcceptance = "B0146";
        public const string MissmatchGlassInformationRequest = "B0147";

        public const string LoadRequest = "B0150";
        public const string LoadOK = "B0151";
        public const string ExchangeRequest = "B0152";

        public const string UnloadRequest = "B0154";
        public const string UnloadOK = "B0155";
        public const string ExchangeOK = "B0156";

        public const string DeliveryPauseRequest = "B0158";
        public const string DeliveryCancelRequest = "B0159";
        public const string RecipeChangeReply = "B015A";
        public const string RoboPenetrationpermission = "B015B";
    }

    public class CCCIM_HandshakeWordEQUnit2
    {
        public const string GlassID_9 = "W0C20";
        public const string PPID_8 = "W0C29";
        public const string LotID_12 = "W0C31";
        public const string StepID_16 = "W0C3D";
        public const string CelRepCount_1 = "W0C4D";
        public const string EQID_5 = "W0C4E";
        public const string CellTestCSTID_4 = "W0C53";
        public const string CollectFlag_2 = "W0C5C";
        public const string Grade_2 = "W0C5E";
        public const string GradeCode_4 = "W0C60";
        public const string MAXPower_4 = "W0C64";
        public const string MINPower_4 = "W0C68";
        public const string AVGPower_4 = "W0C6C";
        public const string STDPower_4 = "W0C70";
    }

    public class CCCIM_HandshakeEqUnit1ES06
    {
        public const string EQStatus_1 = "W0800";
        public const string CurrentRecipeNo_1 = "W0801";
    }

    public class CCCIM_HandshakeEqUnit1EG05
    {
        public const string CstAndSlotNo_1 = "W0810";
        public const string KindNo_1 = "W0811";
    }

    public class CCCIM_HandshakeEqUnit1EG01
    {
        public const string CstAndSlotNo_1 = "W0804";
        public const string KindNo_1 = "W0805";
    }

    public class CCCIM_HandshakeEqUnit1ES05
    {
        public const string NumberOfGlass_1 = "W0812";
    }

    public class CCCIM_HandshakeLUDUnit1ED01
    {
        public const string RecipeData_1 = "W0406";
    }

    public class CCCIM_HandshakeLUDUnit1ES02
    {
        public const string HeavyAlarmCode_1 = "W0802";
        public const string LightAlarmCode_1 = "W0803";
    }


}
