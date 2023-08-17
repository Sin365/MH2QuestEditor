using System.Text;

namespace MHQuestHelperLib
{
    public class MH2Tools
    {
        #region 公开属性
        /// <summary>
        /// 任务信息头部指针
        /// </summary>
        public int QuestInfoPtr => HexHelper.bytesToInt(target, 4, 0x00);

        //固体值
        public int StandInfo_MonsterPtr => 0x48;
        public int StandInfo_Monster => HexHelper.bytesToInt(target, 4, StandInfo_MonsterPtr);
        //小怪强度
        public int StandInfo_SamllMonsterPtr => 0x61;
        public int StandInfo_SamllMonster => HexHelper.bytesToInt(target, 4, StandInfo_SamllMonsterPtr);
        //体型
        public int StandInfo_MonsterSizePtr => 0x44;
        public int StandInfo_MonsterSize => HexHelper.bytesToInt(target, 4, StandInfo_MonsterSizePtr);
        //体型范围
        public int StandInfo_MonsterSizeRangePtr => 0x46;
        public int StandInfo_MonsterSizeRange => HexHelper.bytesToInt(target, 4, StandInfo_MonsterSizeRangePtr);
        public int StandInfo_MainHRPPtr => 0x4C;
        public int StandInfo_MainHRP => HexHelper.bytesToInt(target, 4, StandInfo_MainHRPPtr);
        public int StandInfo_SubAHRPPtr => 0x54;
        public int StandInfo_SubAHRP => HexHelper.bytesToInt(target, 4, StandInfo_SubAHRPPtr);
        public int StandInfo_SubBHRPPtr => 0x58;
        public int StandInfo_SubBHRP => HexHelper.bytesToInt(target, 4, StandInfo_SubBHRPPtr);
        //怪物到达位置
        public int StandInfo_LarBoss_CarvePtr = 0x5C;
        public int StandInfo_LarBoss_Carve => HexHelper.bytesToInt(target, 4, StandInfo_LarBoss_CarvePtr);

        /// <summary>
        /// 角色场景头部指针
        /// </summary>
        public int CharactorScenePtr => HexHelper.bytesToInt(target, 4, 0x04);
        /// <summary>
        /// BOSS头部指针
        /// </summary>
        public int BOSSInFoPtr => HexHelper.bytesToInt(target, 4, 0x18);

        /// <summary>
        /// 怪物1
        /// </summary>
        public int BOSSInFo_Monster1IDPtr => HexHelper.bytesToInt(target, 4, 0x18 + 16);
        public int BOSSInFo_Monster2IDPtr => HexHelper.bytesToInt(target, 4, 0x18 + 16 + 4);
        public int BOSSInFo_Monster3IDPtr => HexHelper.bytesToInt(target, 4, 0x18 + 16 + 8);
        public int BOSSInFo_Monster4IDPtr => HexHelper.bytesToInt(target, 4, 0x18 + 16 + 12);

        /// <summary>
        /// 报酬指针
        /// </summary>
        public int QuestRewardPtr => HexHelper.bytesToInt(target, 4, 0x0C);
        /// <summary>
        /// 支给品指针
        /// </summary>
        public int SuppliesItemPtr => HexHelper.bytesToInt(target, 4, 0x08);
        /// <summary>
        /// 采集点头部指针
        /// </summary>
        public int ItemPointPtr => HexHelper.bytesToInt(target, 4, 0x38);
        /// <summary>
        /// 鱼群指针
        /// </summary>
        public int FishGroupPtr => HexHelper.bytesToInt(target, 4, 0x40);


        #region
        /// <summary>
        /// 契约金指针
        /// </summary>
        public int QuestInfo_StarPtr => QuestInfoPtr + 4;
        public int QuestInfo_Star => HexHelper.bytesToInt(target, 2, QuestInfo_StarPtr);
        /// <summary>
        /// 契约金指针
        /// </summary>
        public int QuestInfo_FeePtr => QuestInfoPtr + 8;
        public int QuestInfo_Fee => HexHelper.bytesToInt(target, 4, QuestInfo_FeePtr);
        /// <summary>
        /// 报酬金指针
        /// </summary>
        public int QuestInfo_RewardMoneyPtr => QuestInfoPtr + 12;
        public int QuestInfo_RewardMoney => HexHelper.bytesToInt(target, 4, QuestInfo_RewardMoneyPtr);
        /// <summary>
        /// 支线A报酬金指针
        /// </summary>
        public int QuestInfo_SubARewardMoneyPtr => QuestInfoPtr + 20;
        public int QuestInfo_SubARewardMoney => HexHelper.bytesToInt(target, 4, QuestInfo_SubARewardMoneyPtr);
        /// <summary>
        /// 支线B报酬金指针
        /// </summary>
        public int QuestInfo_SubBRewardMoneyPtr => QuestInfoPtr + 24;
        public int QuestInfo_SubBRewardMoney => HexHelper.bytesToInt(target, 4, QuestInfo_SubBRewardMoneyPtr);
        /// <summary>
        /// 支线B报酬金指针
        /// </summary>
        public int QuestInfo_TimePtr => QuestInfoPtr + 28;
        public int QuestInfo_Time => HexHelper.bytesToInt(target, 4, QuestInfo_TimePtr);
        /// <summary>
        /// 契约金指针
        /// </summary>
        public int QuestInfo_PenaltyPtr => QuestInfoPtr + 16;
        public int QuestInfo_Penalty => HexHelper.bytesToInt(target, 4, QuestInfo_PenaltyPtr);
        /// <summary>
        /// 主线目标指针
        /// </summary>
        public int QuestInfo_MainTypePtr => QuestInfoPtr + 44;
        public int QuestInfo_MainType => HexHelper.bytesToInt(target, 4, QuestInfo_MainTypePtr);
        /// <summary>
        /// 主线目标（怪或道具）指针
        /// </summary>
        public int QuestInfo_MainTargetIDPtr => QuestInfoPtr + 48;
        public int QuestInfo_MainTargetID => HexHelper.bytesToInt(target, 2, QuestInfo_MainTargetIDPtr);
        /// <summary>
        /// 主线目标（怪或道具）指针
        /// </summary>
        public int QuestInfo_MainTargetCountPtr => QuestInfoPtr + 50;
        public int QuestInfo_MainTargetCount => HexHelper.bytesToInt(target, 2, QuestInfo_MainTargetCountPtr);
        /// <summary>
        /// 支线A目标指针
        /// </summary>
        public int QuestInfo_SubATypePtr => QuestInfoPtr + 52;
        public int QuestInfo_SubAType => HexHelper.bytesToInt(target, 4, QuestInfo_SubATypePtr);
        /// <summary>
        /// 支线A目标（怪或道具）指针
        /// </summary>
        public int QuestInfo_SubATargetIDPtr => QuestInfoPtr + 56;
        public int QuestInfo_SubATargetID => HexHelper.bytesToInt(target, 2, QuestInfo_SubATargetIDPtr);
        /// <summary>
        /// 支线A目标（怪或道具）指针
        /// </summary>
        public int QuestInfo_SubATargetCountPtr => QuestInfoPtr + 58;
        public int QuestInfo_SubATargetCount => HexHelper.bytesToInt(target, 2, QuestInfo_SubATargetCountPtr);

        /// <summary>
        /// 支线B目标指针
        /// </summary>
        public int QuestInfo_SubBTypePtr => QuestInfoPtr + 60;
        public int QuestInfo_SubBType => HexHelper.bytesToInt(target, 4, QuestInfo_SubBTypePtr);
        /// <summary>
        /// 支线B目标（怪或道具）指针
        /// </summary>
        public int QuestInfo_SubBTargetIDPtr => QuestInfoPtr + 64;
        public int QuestInfo_SubBTargetID => HexHelper.bytesToInt(target, 2, QuestInfo_SubBTargetIDPtr);
        /// <summary>
        /// 支线B目标（怪或道具）指针
        /// </summary>
        public int QuestInfo_SubBTargetCountPtr => QuestInfoPtr + 66;
        public int QuestInfo_SubBTargetCount => HexHelper.bytesToInt(target, 2, QuestInfo_SubBTargetCountPtr);
        #endregion

        #region 文本类细节指针
        /// <summary>
        /// 任务文本开头指针
        /// </summary>
        public int QuestStrings_StartPtr => HexHelper.bytesToInt(target, 4, QuestInfoPtr + 36);
        /// <summary>
        /// 任务文本开头指针
        /// </summary>
        public int QuestStrings_TitleAndNamePtr => HexHelper.bytesToInt(target, 4, QuestStrings_StartPtr);
        public int QuestStrings_MainoObjPtr => HexHelper.bytesToInt(target, 4, QuestStrings_StartPtr + 4);
        public int QuestStrings_AObjPtr => HexHelper.bytesToInt(target, 4, QuestStrings_StartPtr + 8);
        public int QuestStrings_BObjPtr => HexHelper.bytesToInt(target, 4, QuestStrings_StartPtr + 12);
        public int QuestStrings_ClearCPtr => HexHelper.bytesToInt(target, 4, QuestStrings_StartPtr + 16);
        public int QuestStrings_FailCPtr => HexHelper.bytesToInt(target, 4, QuestStrings_StartPtr + 20);
        public int QuestStrings_HirerPtr => HexHelper.bytesToInt(target, 4, QuestStrings_StartPtr + 24);
        public int QuestStrings_TextPtr => HexHelper.bytesToInt(target, 4, QuestStrings_StartPtr + 28);
        #endregion

        #endregion

        byte[] target;
        public MH2Tools(byte[] src) 
        {
            target = HexHelper.CopyByteArr(src);//加载数据
        }

        #region 指针查询类

        #endregion

        #region 读取类

        public byte[] GetCurrData()
        {
            return target;
        }

        public byte[] GetFullData(int lenght, int offset)
        {
            return HexHelper.ReadBytes(target, lenght,offset);
        }

        #endregion

        #region 操作类

        public void ModifyByte(int index, byte data)
        {
            target[index] = data;
        }

        public void ModifyStringToBytes(string newdata, int startoffset)
        {
            List<byte> data = Encoding.GetEncoding("Shift_JIS").GetBytes(newdata.Replace("\r\n", "\n")).ToList();
            if (data[data.Count - 1] != 0x00)
            {
                //Write
                List<byte> divider = new List<byte>
                {
                    00
                };
                data.AddRange(divider);
            }
                
            HexHelper.ModifyDataToBytes(target, data.ToArray(), startoffset);
        }

        /**  
        * 写入byte[]到byte[]
        */
        public void ModifyDataToBytes(byte[] targetVal, int startoffset)
        {
            HexHelper.ModifyDataToBytes(target, targetVal, startoffset);
        }
        #endregion
    }
}