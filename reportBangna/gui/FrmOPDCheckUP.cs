using reportBangna.object1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reportBangna.gui
{
    public partial class FrmOPDCheckUP : Form
    {
        BangnaControl bc;
        OPDCheckUP opdc;
        Boolean pageLoad = false, keyDistrict = false;

        String id = "";
        public FrmOPDCheckUP(BangnaControl c, String hn)
        {
            InitializeComponent();
            bc = c;
            //id = opdcid;
            initConfig();
        }
        public FrmOPDCheckUP(String hn)
        {
            InitializeComponent();
            bc = new BangnaControl();
            //id = opdcid;
            initConfig();
        }
        private void initConfig()
        {
            opdc = new OPDCheckUP();
            setControl("");
        }

        private void setControl(String hn)
        {
            if (hn.Equals("")){
                return;
            }
            
            opdc = bc.opdcdb.selectByHn(hn);
            if(!opdc.Id.Equals(""))
            {
                txtABOGroup.Text = opdc.ABOGroup;
                txtAddr1.Text = opdc.Addr1;
                txtAddr2.Text = opdc.Addr2;
                txtAge.Text = opdc.Age;
                txtAllergisOther.Text = opdc.AllergicOther;
                txtBloodPressure.Text = opdc.BloodPressure;
                txtBreath.Text = opdc.Breath;
                txtCBCAtrN.Text = opdc.CBCAtrLyN;
                txtCBCAtrV.Text = opdc.CBCAtrLyV;
                txtCBCBasN.Text = opdc.CBCBasN;
                txtCBCBasV.Text = opdc.CBCBasV;
                txtCBCEosN.Text = opdc.CBCEosN;
                txtCBCEosV.Text = opdc.CBCEosV;
                txtCBCHbN.Text = opdc.CBCHbN;
                txtCBCHbV.Text = opdc.CBCHbV;
                txtCBCHctN.Text = opdc.CBCHctN;
                txtCBCHctV.Text = opdc.CBCHctV;
                txtCBCLyN.Text = opdc.CBCLyN;
                txtCBCLyV.Text = opdc.CBCLyV;
                txtCBCMchcN.Text = opdc.CBCMchcN;
                txtCBCMchcV.Text = opdc.CBCMchcV;
                txtCBCMchN.Text = opdc.CBCMchN;
                txtCBCMchV.Text = opdc.CBCMchV;
                txtCBCMcvN.Text = opdc.CBCMcvN;
                txtCBCMcvV.Text = opdc.CBCMcvV;
                txtCBCMonoN.Text = opdc.CBCMonoN;
                txtCBCMonoV.Text = opdc.CBCMonoV;
                txtCBCOtherCN.Text = opdc.CBCOtherCellN;
                txtCBCOtherCV.Text = opdc.CBCOtherCellV;
                txtCBCPlaCntN.Text = opdc.CBCPlaCntN;
                txtCBCPlaCntV.Text = opdc.CBCPlaCntV;
                txtCBCPlaSmeN.Text = opdc.CBCPLaSmeN;
                txtCBCPlaSmeV.Text = opdc.CBCPlaSmeV;
                txtCBCPmnN.Text = opdc.CBCPmnN;
                txtCBCPmnV.Text = opdc.CBCPmnV;
                txtCBCRBCCntN.Text = opdc.CBCRBCCntN;
                txtCBCRBCCntV.Text = opdc.CBCRBCCntV;
                txtCBCRbcMorN.Text = opdc.CBCRBCMorN;
                txtCBCRbcMorV.Text = opdc.CBCRBCMorV;
                txtCBCResult.Text = opdc.CBCResult;
                txtCBCSuggest.Text = opdc.CBCSuggest;
                txtCBCWBCCntN.Text = opdc.CBCWBCCntN;
                txtCBCWBCCntV.Text = opdc.CBCWBCCntV;
                txtCholN.Text = opdc.CholN;
                txtCholResult.Text = opdc.CholResult;
                txtCholSuggest.Text = opdc.CholSuggest;
                txtCholV.Text = opdc.CholV;
                txtCreatiN.Text = opdc.CreatiN;
                txtCreatiResult.Text = opdc.CreatiResult;
                txtCreatiSuggest.Text = opdc.CreatiSuggest;
                txtCreatiV.Text = opdc.CreatiV;
                txtFbsN.Text = opdc.FBSN;
                txtFbsResult.Text = opdc.FBSResult;
                txtFbsSuggest.Text = opdc.FBSSuggest;
                txtFbsV.Text = opdc.FBSV;
                txtHeight.Text = opdc.Height;
                txtHisOther.Text = opdc.HistOther;
                txtHn.Text = opdc.HN;
                txtOROther.Text = opdc.OROther;
                txtPatientName.Text = opdc.Name;
                txtPhone.Text = opdc.Phone;
                txtPulse.Text = opdc.Pulse;
                txtResult.Text = opdc.Result;
                txtRhgroup.Text = opdc.RhGroup;
                txtSex.Text = opdc.Sex;
                txtSgotN.Text = opdc.SgotN;
                txtSgotResult.Text = opdc.SgotResult;
                txtSgotSuggest.Text = opdc.SgotSuggest;
                txtSgotV.Text = opdc.SgotV;
                txtSgptN.Text = opdc.SgptN;
                txtSgptV.Text = opdc.SgptV;
                txtSuggest.Text = opdc.Suggest;
                txtTempu.Text = opdc.Tempu;
                txtWeight.Text = opdc.Weight;
            }
            else
            {
                String date = "";
                date = System.DateTime.Today.Year+"-"+System.DateTime.Today.ToString("MM-dd");
                DataTable dt = bc.vsdb.selectVisitByHn2(hn, date);
                //DataTable dtor = bc.selectOPDViewOR(hn);
                if (dt.Rows.Count <= 0)
                {
                    clearControl();
                    return;
                }
                txtABOGroup.Text = dt.Rows[0]["mnc_blo_grp"].ToString();
                
                txtAddr1.Text = dt.Rows[0]["mnc_full_add"].ToString()!=""? dt.Rows[0]["mnc_full_add"].ToString(): dt.Rows[0]["mnc_dom_add"].ToString() + " " + dt.Rows[0]["mnc_tum_dsc"].ToString()+" "+ dt.Rows[0]["mnc_amp_dsc"].ToString()+" "+dt.Rows[0]["mnc_chw_dsc"].ToString() + " " + dt.Rows[0]["mnc_cur_poc"].ToString();
                txtAddr2.Text = "";
                txtAge.Text = dt.Rows[0]["MNC_AGE"].ToString();
                //txtAllergisOther.Text = dt.Rows[0][bc.opdcdb.opdc.AllergicOther].ToString();
                //txtBloodPressure.Text = dt.Rows[0][bc.opdcdb.opdc.BloodPressure].ToString();
                txtBreath.Text = dt.Rows[0]["mnc_breath"].ToString();
                
                
                txtHeight.Text = dt.Rows[0]["mnc_high"].ToString();
                //txtHisOther.Text = dt.Rows[0][bc.opdcdb.opdc.HistOther].ToString();
                txtHn.Text = dt.Rows[0]["MNC_HN_NO"].ToString();
                txtOROther.Text = dt.Rows[0]["MNC_HN_NO"].ToString();
                txtPatientName.Text = dt.Rows[0]["prefix"].ToString()+" "+ dt.Rows[0]["MNC_FNAME_T"].ToString() + " " + dt.Rows[0]["MNC_LNAME_T"].ToString();
                txtPhone.Text = dt.Rows[0]["mnc_cur_tel"].ToString();
                txtBloodPressure.Text = dt.Rows[0]["mnc_bp1_l"].ToString();
                //txtResult.Text = dt.Rows[0][bc.opdcdb.opdc.Result].ToString();
                txtRhgroup.Text = dt.Rows[0]["mnc_blo_rh"].ToString();
                txtSex.Text = dt.Rows[0]["mnc_sex"].ToString();
                
                //txtSuggest.Text = dt.Rows[0][bc.opdcdb.opdc.Suggest].ToString();
                txtTempu.Text = dt.Rows[0]["mnc_temp"].ToString();
                txtWeight.Text = dt.Rows[0]["mnc_weight"].ToString();
                txtVn.Text = dt.Rows[0]["MNC_VN_NO"].ToString() + "." + dt.Rows[0]["MNC_VN_SEQ"].ToString() + "." + dt.Rows[0]["MNC_VN_SUM"].ToString();
                //DataTable dtlab = bc.vsdb.selectLAB(hn, dt.Rows[0]["MNC_VN_NO"].ToString(), dt.Rows[0]["MNC_PRE_NO"].ToString());
                txtPreNo.Text = dt.Rows[0]["MNC_pre_no"].ToString();
                txtOROther.Text = bc.selectOPDViewOR(hn);
                chkORStatusHave.Checked = txtOROther.Text == "" ? true : false;
                chkORStatusNo.Checked = txtOROther.Text != "" ? true : false;

                txtHisOther.Text = bc.selectOPDViewHistory(hn, dt.Rows[0]["MNC_pre_no"].ToString(), dt.Rows[0]["MNC_VN_NO"].ToString());
                chkHisStatusHave.Checked = txtHisOther.Text == "" ? true : false;
                chkHisStatusNo.Checked = txtHisOther.Text != "" ? true : false;

                //DataTable dtlab = bc.vsdb.selectLAB(hn, dt.Rows[0]["MNC_VN_NO"].ToString(), txtPreNo.Text);
                DataTable dtlab = bc.vsdb.selectLAB(hn, dt.Rows[0]["MNC_VN_NO"].ToString(), txtPreNo.Text);
                if (dtlab.Rows.Count > 0)
                {
                    for(int i = 0; i < dtlab.Rows.Count; i++)
                    {
                        if (dtlab.Rows[i]["mnc_lb_cd"].ToString().Equals("HE001"))
                        {
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("01"))
                            {
                                txtCBCWBCCntN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCWBCCntV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCWBCCntN.Checked = true;
                                    chkCBCWBCCntA.Checked = false;
                                }
                                else
                                {
                                    chkCBCWBCCntN.Checked = false;
                                    chkCBCWBCCntA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("02"))
                            {
                                txtCBCRBCCntN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCRBCCntV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCRBCCntN.Checked = true;
                                    chkCBCRBCCntA.Checked = false;
                                }
                                else
                                {
                                    chkCBCRBCCntN.Checked = false;
                                    chkCBCRBCCntA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("03") && txtSex.Text.Equals("M"))
                            {
                                txtCBCHbN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCHbV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCHbN.Checked = true;
                                    chkCBCHbA.Checked = false;
                                }
                                else
                                {
                                    chkCBCHbN.Checked = false;
                                    chkCBCHbA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("04") && txtSex.Text.Equals("F"))
                            {
                                txtCBCHbN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCHbV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCHbN.Checked = true;
                                    chkCBCHbA.Checked = false;
                                }
                                else
                                {
                                    chkCBCHbN.Checked = false;
                                    chkCBCHbA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("05") && txtSex.Text.Equals("M"))
                            {
                                txtCBCHctN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCHctV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCHctN.Checked = true;
                                    chkCBCHctA.Checked = false;
                                }
                                else
                                {
                                    chkCBCHctN.Checked = false;
                                    chkCBCHctA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("06") && txtSex.Text.Equals("F"))
                            {
                                txtCBCHctN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCHctV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCHctN.Checked = true;
                                    chkCBCHctA.Checked = false;
                                }
                                else
                                {
                                    chkCBCHctN.Checked = false;
                                    chkCBCHctA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("07"))
                            {
                                //txtCBCOtherCN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCOtherCellN].ToString();
                                //txtCBCOtherCV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCOtherCellV].ToString();
                                txtCBCOtherCN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCOtherCV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCOtherCN.Checked = true;
                                    chkCBCOtherCA.Checked = false;
                                }
                                else
                                {
                                    chkCBCOtherCN.Checked = false;
                                    chkCBCOtherCA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("14"))
                            {
                                //txtCBCEosN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCEosN].ToString();
                                //txtCBCEosV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCEosV].ToString();
                                txtCBCEosN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCEosV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCEosN.Checked = true;
                                    chkCBCEosA.Checked = false;
                                }
                                else
                                {
                                    chkCBCEosN.Checked = false;
                                    chkCBCEosA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("15"))
                            {
                                //txtCBCBasN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCBasN].ToString();
                                //txtCBCBasV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCBasV].ToString();
                                txtCBCBasN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCBasV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCBasN.Checked = true;
                                    chkCBCBasA.Checked = false;
                                }
                                else
                                {
                                    chkCBCBasN.Checked = false;
                                    chkCBCBasA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("16"))
                            {
                                //txtCBCAtrN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCAtrLyN].ToString();
                                //txtCBCAtrV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCAtrLyV].ToString();
                                txtCBCAtrN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCAtrV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCAtrN.Checked = true;
                                    chkCBCAtrA.Checked = false;
                                }
                                else
                                {
                                    chkCBCAtrN.Checked = false;
                                    chkCBCAtrA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("17"))
                            {
                                //txtCBCPlaCntN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCPlaCntN].ToString();
                                //txtCBCPlaCntV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCPlaCntV].ToString();
                                txtCBCPlaCntN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCPlaCntV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCPlaCntN.Checked = true;
                                    chkCBCPlaCntA.Checked = false;
                                }
                                else
                                {
                                    chkCBCPlaCntN.Checked = false;
                                    chkCBCPlaCntA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("18"))
                            {
                                //txtCBCPlaSmeN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCPLaSmeN].ToString();
                                //txtCBCPlaSmeV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCPlaSmeV].ToString();
                                txtCBCPlaSmeN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCPlaSmeV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCPlaSmeN.Checked = true;
                                    chkCBCPlaSmeA.Checked = false;
                                }
                                else
                                {
                                    chkCBCPlaSmeN.Checked = false;
                                    chkCBCPlaSmeA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("19"))
                            {
                                //txtCBCRbcMorN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCRBCMorN].ToString();
                                //txtCBCRbcMorV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCRBCMorV].ToString();
                                txtCBCRbcMorN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCRbcMorV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCRbcMorN.Checked = true;
                                    chkCBCRbcMorA.Checked = false;
                                }
                                else
                                {
                                    chkCBCRbcMorN.Checked = false;
                                    chkCBCRbcMorA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("08"))
                            {
                                //txtCBCMcvN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCMcvN].ToString();
                                //txtCBCMcvV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCMcvV].ToString();
                                txtCBCMcvN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCMcvV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCMcvN.Checked = true;
                                    chkCBCMcvA.Checked = false;
                                }
                                else
                                {
                                    chkCBCMcvN.Checked = false;
                                    chkCBCMcvA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("09"))
                            {
                                //txtCBCMchN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCMchN].ToString();
                                //txtCBCMchV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCMchV].ToString();
                                txtCBCMchN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCMchV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCMchN.Checked = true;
                                    chkCBCMchA.Checked = false;
                                }
                                else
                                {
                                    chkCBCMchN.Checked = false;
                                    chkCBCMchA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("10"))
                            {
                                //txtCBCMchcN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCMchcN].ToString();
                                //txtCBCMchcV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCMchcV].ToString();
                                txtCBCMchcN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCMchcV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCMchcN.Checked = true;
                                    chkCBCMchcA.Checked = false;
                                }
                                else
                                {
                                    chkCBCMchcN.Checked = false;
                                    chkCBCMchcA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("11"))
                            {
                                //txtCBCPmnN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCPmnN].ToString();
                                //txtCBCPmnV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCPmnV].ToString();
                                txtCBCPmnN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCPmnV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCPmnN.Checked = true;
                                    chkCBCPmnA.Checked = false;
                                }
                                else
                                {
                                    chkCBCPmnN.Checked = false;
                                    chkCBCPmnA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("12"))
                            {
                                //txtCBCLyN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCLyN].ToString();
                                //txtCBCLyV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCLyV].ToString();
                                txtCBCLyN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCLyV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCLyN.Checked = true;
                                    chkCBCLyA.Checked = false;
                                }
                                else
                                {
                                    chkCBCLyN.Checked = false;
                                    chkCBCLyA.Checked = true;
                                }
                            }
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("13"))
                            {
                                //txtCBCMonoN.Text = dt.Rows[0][bc.opdcdb.opdc.CBCMonoN].ToString();
                                //txtCBCMonoV.Text = dt.Rows[0][bc.opdcdb.opdc.CBCMonoV].ToString();
                                txtCBCMonoN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCBCMonoV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCBCMonoN.Checked = true;
                                    chkCBCMonoA.Checked = false;
                                }
                                else
                                {
                                    chkCBCMonoN.Checked = false;
                                    chkCBCMonoA.Checked = true;
                                }
                            }
                        }else if (dtlab.Rows[i]["mnc_lb_cd"].ToString().Equals("CH006"))
                        {
                            txtCholN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                            //txtCBCMonoV.Text = dtlab.Rows[i]["mnc_res_value"].ToString();
                            txtCholV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                            if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                            {
                                chkCholN.Checked = true;
                                chkCholA.Checked = false;
                            }
                            else
                            {
                                chkCholN.Checked = false;
                                chkCholA.Checked = true;
                            }
                            //}
                        }
                        else if (dtlab.Rows[i]["mnc_lb_cd"].ToString().Equals("CH004"))
                        {
                            //txtCreatiN.Text = dt.Rows[0][bc.opdcdb.opdc.CreatiN].ToString();
                            //txtCreatiV.Text = dt.Rows[0][bc.opdcdb.opdc.CreatiV].ToString();
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("01") && txtSex.Text.Equals("M"))//Male
                            {
                                txtCreatiN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCreatiV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCreatiN.Checked = true;
                                    chkCreatiA.Checked = false;
                                }
                                else
                                {
                                    chkCreatiN.Checked = false;
                                    chkCreatiA.Checked = true;
                                }
                            }else if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("02") && txtSex.Text.Equals("F"))//FeMale
                            {
                                txtCreatiN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtCreatiV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkCreatiN.Checked = true;
                                    chkCreatiA.Checked = false;
                                }
                                else
                                {
                                    chkCreatiN.Checked = false;
                                    chkCreatiA.Checked = true;
                                }
                            }

                            //}
                        }
                        else if (dtlab.Rows[i]["mnc_lb_cd"].ToString().Equals("CH016"))
                        {
                            //txtSgotN.Text = dt.Rows[0][bc.opdcdb.opdc.SgotN].ToString();
                            //txtSgotV.Text = dt.Rows[0][bc.opdcdb.opdc.SgotV].ToString();
                            txtSgotN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                            txtSgotV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                            if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                            {
                                chkSgotN.Checked = true;
                                chkSgotA.Checked = false;
                            }
                            else
                            {
                                chkSgotN.Checked = false;
                                chkSgotA.Checked = true;
                            }
                            //}
                        }
                        else if (dtlab.Rows[i]["mnc_lb_cd"].ToString().Equals("CH017"))
                        {
                            if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("01") && txtSex.Text.Equals("M"))//Male
                            {
                                txtSgptN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtSgptV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkSgotN.Checked = true;
                                    chkSgotA.Checked = false;
                                }
                                else
                                {
                                    chkSgotN.Checked = false;
                                    chkSgotA.Checked = true;
                                }
                            }
                            else if (dtlab.Rows[i]["mnc_lb_res_cd"].ToString().Equals("02") && txtSex.Text.Equals("F"))//FeMale
                            {
                                txtSgptN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                txtSgptV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                                if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                                {
                                    chkSgotN.Checked = true;
                                    chkSgotA.Checked = false;
                                }
                                else
                                {
                                    chkSgotN.Checked = false;
                                    chkSgotA.Checked = true;
                                }
                            }
                            
                            //txtSgptN.Text = dt.Rows[0][bc.opdcdb.opdc.SgptN].ToString();
                            //txtSgptV.Text = dt.Rows[0][bc.opdcdb.opdc.SgptV].ToString();

                        }
                        else if (dtlab.Rows[i]["mnc_lb_cd"].ToString().Equals("CH002"))
                        {
                            //txtSgotN.Text = dt.Rows[0][bc.opdcdb.opdc.SgotN].ToString();
                            //txtSgotV.Text = dt.Rows[0][bc.opdcdb.opdc.SgotV].ToString();
                            txtFbsN.Text = dtlab.Rows[i]["mnc_lb_res"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                            txtFbsV.Text = dtlab.Rows[i]["mnc_res_value"].ToString() + " " + dtlab.Rows[i]["mnc_res_unt"].ToString();
                            if (dtlab.Rows[i]["mnc_sts"].ToString().Equals("Normal"))
                            {
                                chkFbsN.Checked = true;
                                chkFbsA.Checked = false;
                            }
                            else
                            {
                                chkFbsN.Checked = false;
                                chkFbsA.Checked = true;
                            }
                            //}
                        }
                    }
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    
                    //txtCBCResult.Text = dt.Rows[0][bc.opdcdb.opdc.CBCResult].ToString();
                    //txtCBCSuggest.Text = dt.Rows[0][bc.opdcdb.opdc.CBCSuggest].ToString();
                    

                    
                    //txtCholResult.Text = dt.Rows[0][bc.opdcdb.opdc.CholResult].ToString();
                    //txtCholSuggest.Text = dt.Rows[0][bc.opdcdb.opdc.CholSuggest].ToString();
                    
                    
                    //txtCreatiResult.Text = dt.Rows[0][bc.opdcdb.opdc.CreatiResult].ToString();
                    //txtCreatiSuggest.Text = dt.Rows[0][bc.opdcdb.opdc.CreatiSuggest].ToString();
                    
                    
                    //txtFbsResult.Text = dt.Rows[0][bc.opdcdb.opdc.FBSResult].ToString();
                    //txtFbsSuggest.Text = dt.Rows[0][bc.opdcdb.opdc.FBSSuggest].ToString();
                    

                    
                    //txtSgotResult.Text = dt.Rows[0][bc.opdcdb.opdc.SgotResult].ToString();
                    //txtSgotSuggest.Text = dt.Rows[0][bc.opdcdb.opdc.SgotSuggest].ToString();
                    
                    
                }
            }
        }
        private void clearControl()
        {
            txtABOGroup.Text ="";
            txtAddr1.Text = "";
            txtAddr2.Text = "";
            txtAge.Text = "";
            txtAllergisOther.Text = "";
            txtBloodPressure.Text = "";
            txtBreath.Text = "";
            txtCBCAtrN.Text = "";
            txtCBCAtrV.Text = "";
            txtCBCBasN.Text = "";
            txtCBCBasV.Text = "";
            txtCBCEosN.Text = "";
            txtCBCEosV.Text = "";
            txtCBCHbN.Text = "";
            txtCBCHbV.Text = "";
            txtCBCHctN.Text = "";
            txtCBCHctV.Text = "";
            txtCBCLyN.Text = "";
            txtCBCLyV.Text = "";
            txtCBCMchcN.Text = "";
            txtCBCMchcV.Text = "";
            txtCBCMchN.Text = "";
            txtCBCMchV.Text = "";
            txtCBCMcvN.Text = "";
            txtCBCMcvV.Text = "";
            txtCBCMonoN.Text = "";
            txtCBCMonoV.Text = "";
            txtCBCOtherCN.Text = "";
            txtCBCOtherCV.Text = "";
            txtCBCPlaCntN.Text = "";
            txtCBCPlaCntV.Text = "";
            txtCBCPlaSmeN.Text = "";
            txtCBCPlaSmeV.Text = "";
            txtCBCPmnN.Text = "";
            txtCBCPmnV.Text = "";
            txtCBCRBCCntN.Text = "";
            txtCBCRBCCntV.Text = "";
            txtCBCRbcMorN.Text = "";
            txtCBCRbcMorV.Text = "";
            txtCBCResult.Text = "";
            txtCBCSuggest.Text = "";
            txtCBCWBCCntN.Text = "";
            txtCBCWBCCntV.Text = "";
            txtCholN.Text = "";
            txtCholResult.Text = "";
            txtCholSuggest.Text = "";
            txtCholV.Text = "";
            txtCreatiN.Text = "";
            txtCreatiResult.Text = "";
            txtCreatiSuggest.Text = "";
            txtCreatiV.Text = "";
            txtFbsN.Text = "";
            txtFbsResult.Text = "";
            txtFbsSuggest.Text = "";
            txtFbsV.Text = "";
            txtHeight.Text = "";
            txtHisOther.Text = "";
            txtHn.Text = "";
            txtOROther.Text = "";
            txtPatientName.Text = "";
            txtPhone.Text = "";
            txtPulse.Text = "";
            txtResult.Text = "";
            txtRhgroup.Text = "";
            txtSex.Text = "";
            txtSgotN.Text = "";
            txtSgotResult.Text = "";
            txtSgotSuggest.Text = "";
            txtSgotV.Text = "";
            txtSgptN.Text = "";
            txtSgptV.Text = "";
            txtSuggest.Text = "";
            txtTempu.Text = "";
            txtWeight.Text = "";
        }
        private OPDCheckUP setOPDCheckUP()
        {
            OPDCheckUP p = new OPDCheckUP();
            p.ABOGroup = txtABOGroup.Text ;
            p.Addr1 = txtAddr1.Text;
            p.Addr2 = txtAddr2.Text ;
            p.Age = txtAge.Text ;
            p.AllergicOther = txtAllergisOther.Text ;
            p.BloodPressure = txtBloodPressure.Text ;
            p.Breath = txtBreath.Text ;
            p.CBCAtrLyN = txtCBCAtrN.Text;
            p.CBCAtrLyV = txtCBCAtrV.Text ;
            p.CBCBasN = txtCBCBasN.Text ;
            p.CBCBasV = txtCBCBasV.Text ;
            p.CBCEosN = txtCBCEosN.Text ;
            p.CBCEosV = txtCBCEosV.Text ;
            p.CBCHbN = txtCBCHbN.Text ;
            p.CBCHbV = txtCBCHbV.Text ;
            p.CBCHctN = txtCBCHctN.Text ;
            p.CBCHctV = txtCBCHctV.Text;
            p.CBCLyN = txtCBCLyN.Text ;
            p.CBCLyV = txtCBCLyV.Text;
            p.CBCMchcN = txtCBCMchcN.Text ;
            p.CBCMchcV = txtCBCMchcV.Text;
            p.CBCMchN = txtCBCMchN.Text ;
            p.CBCMchV = txtCBCMchV.Text ;
            p.CBCMcvN = txtCBCMcvN.Text;
            p.CBCMcvV = txtCBCMcvV.Text ;
            p.CBCMonoN = txtCBCMonoN.Text ;
            p.CBCMonoV = txtCBCMonoV.Text;
            p.CBCOtherCellN = txtCBCOtherCN.Text;
            p.CBCOtherCellV = txtCBCOtherCV.Text;
            p.CBCPlaCntN = txtCBCPlaCntN.Text;
            p.CBCPlaCntV = txtCBCPlaCntV.Text ;
            p.CBCPLaSmeN = txtCBCPlaSmeN.Text ;
            p.CBCPlaSmeV = txtCBCPlaSmeV.Text ;
            p.CBCPmnN = txtCBCPmnN.Text ;
            p.CBCPmnV = txtCBCPmnV.Text ;
            p.CBCRBCCntN = txtCBCRBCCntN.Text ;
            p.CBCRBCCntV = txtCBCRBCCntV.Text ;
            p.CBCRBCMorN = txtCBCRbcMorN.Text ;
            p.CBCRBCMorV = txtCBCRbcMorV.Text ;
            p.CBCResult = txtCBCResult.Text ;
            p.CBCSuggest = txtCBCSuggest.Text ;
            p.CBCWBCCntN = txtCBCWBCCntN.Text ;
            p.CBCWBCCntV = txtCBCWBCCntV.Text ;
            p.CholN = txtCholN.Text ;
            p.CholResult = txtCholResult.Text ;
            p.CholSuggest = txtCholSuggest.Text ;
            p.CholV = txtCholV.Text ;
            p.CreatiN = txtCreatiN.Text ;
            p.CreatiResult = txtCreatiResult.Text ;
            p.CreatiSuggest = txtCreatiSuggest.Text ;
            p.CreatiV = txtCreatiV.Text ;
            p.FBSN = txtFbsN.Text ;
            p.FBSResult = txtFbsResult.Text;
            p.FBSSuggest = txtFbsSuggest.Text;
            p.FBSV = txtFbsV.Text ;
            p.Height = txtHeight.Text;
            p.HistOther = txtHisOther.Text ;
            p.HN = txtHn.Text ;
            p.OROther = txtOROther.Text ;
            p.Name = txtPatientName.Text ;
            p.Phone = txtPhone.Text ;
            p.Pulse = txtPulse.Text;
            p.Result = txtResult.Text ;
            p.RhGroup = txtRhgroup.Text ;
            p.Sex = txtSex.Text ;
            p.SgotN = txtSgotN.Text ;
            p.SgotResult = txtSgotResult.Text ;
            p.SgotSuggest = txtSgotSuggest.Text ;
            p.SgotV = txtSgotV.Text ;
            p.SgptN = txtSgptN.Text;
            p.SgptV = txtSgptV.Text ;
            p.Suggest = txtSuggest.Text;
            p.Tempu = txtTempu.Text ;
            p.Weight = txtWeight.Text ;
            return p;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setControl(txtHn.Text);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            opdc = setOPDCheckUP();
            try
            {
                String id = bc.opdcdb.insertOPDCheckUP(opdc);
                txtId.Text = id;

            }
            catch (Exception ex)
            {

            }
        }

        private void txtHn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                setControl(txtHn.Text);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //pB1.Show();
            Microsoft.Office.Interop.Excel.Application excelapp = new Microsoft.Office.Interop.Excel.Application();
            excelapp.Visible = false;
            String visitDate = "", visitTime = "", err = "", err1 = "", pharName = "";

            //Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Add(Type.Missing));
            Microsoft.Office.Interop.Excel._Workbook workbook = (Microsoft.Office.Interop.Excel._Workbook)(excelapp.Workbooks.Open(@"d:\opdcheckup.xlsx"));
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            //pB1.Minimum = 0;
            //pB1.Maximum = dgvAdd.Rows.Count;
            //worksheet.Cells[0, 0] = "patient name";
            //for (int i = 1; i < dgvAdd.Rows.Count; i++)
            //{
                try
                {
                worksheet.Cells[6, 2] = txtPatientName.Text;
                worksheet.Cells[7, 2] = txtSex.Text;
            //err = "001 " + dgvAdd[colPatientHnno, i].Value.ToString();
                worksheet.Cells[8, 2] = txtAddr1.Text;
                worksheet.Cells[9, 2] = txtPhone.Text;
                worksheet.Cells[12, 1] = chkHisStatusNo.Checked ? "ไม่มี" : "มี ได้แก่ " + txtHisOther.Text;
                worksheet.Cells[14, 2] = chkORStatusNo.Checked ? "ไม่มี" :  "มี ได้แก่ "+txtOROther.Text;
                //worksheet.Cells[12, 1] = txtOROther.Text;
                worksheet.Cells[17, 1] = "หมู่เลือด " + txtRhgroup.Text+"      น้ำหนัก " + txtWeight.Text + "      ส่วนสูง " + txtHeight.Text+ "      ความดันโลหิต " + txtBloodPressure.Text + "      อุณหภูมิ " + txtTempu.Text + "      ชีพจร " + txtPulse.Text + "      หายใจ " + txtBreath.Text;
                //worksheet.Cells[18, 2] = 
                worksheet.Cells[24, 2] = txtCBCWBCCntN.Text;
                worksheet.Cells[24, 3] = txtCBCWBCCntV.Text;
                //worksheet.Cells[24, 4] = chkCBCWBCCntN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal" ;
                worksheet.Cells[25, 2] = txtCBCRBCCntN.Text;
                worksheet.Cells[25, 3] = txtCBCRBCCntV.Text;
                //worksheet.Cells[25, 4] = chkCBCRBCCntN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[26, 2] = txtCBCHbN.Text;
                worksheet.Cells[26, 3] = txtCBCHbV.Text;
                //worksheet.Cells[26, 4] = chkCBCHbN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[27, 2] = txtCBCHctN.Text;
                worksheet.Cells[27, 3] = txtCBCHctV.Text;
                //worksheet.Cells[27, 4] = chkCBCHctN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[28, 2] = txtCBCMcvN.Text;
                worksheet.Cells[28, 3] = txtCBCMcvV.Text;
                //worksheet.Cells[28, 4] = chkCBCMcvN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[29, 2] = txtCBCMchN.Text;
                worksheet.Cells[29, 3] = txtCBCMchV.Text;
                //worksheet.Cells[29, 4] = chkCBCMchN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[30, 2] = txtCBCMchcN.Text;
                worksheet.Cells[30, 3] = txtCBCMchcV.Text;
                //worksheet.Cells[30, 4] = chkCBCMchcN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[31, 2] = txtCBCPmnN.Text;
                worksheet.Cells[31, 3] = txtCBCPmnV.Text;
                //worksheet.Cells[31, 4] = chkCBCPmnN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[32, 2] = txtCBCLyN.Text;
                worksheet.Cells[32, 3] = txtCBCLyV.Text;
                //worksheet.Cells[32, 4] = chkCBCLyN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[33, 2] = txtCBCMonoN.Text;
                worksheet.Cells[33, 3] = txtCBCMonoV.Text;
                //worksheet.Cells[33, 4] = chkCBCMonoN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[34, 2] = txtCBCEosN.Text;
                worksheet.Cells[34, 3] = txtCBCEosV.Text;
                //worksheet.Cells[34, 4] = chkCBCEosN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[35, 2] = txtCBCBasN.Text;
                worksheet.Cells[35, 3] = txtCBCBasV.Text;
                //worksheet.Cells[35, 4] = chkCBCBasN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[36, 2] = txtCBCAtrN.Text;
                worksheet.Cells[36, 3] = txtCBCAtrV.Text;
                //worksheet.Cells[36, 4] = chkCBCAtrN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[37, 2] = txtCBCPlaCntN.Text;
                worksheet.Cells[37, 3] = txtCBCPlaCntV.Text;
                //worksheet.Cells[37, 4] = chkCBCPlaCntN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[38, 2] = txtCBCPlaSmeN.Text;
                worksheet.Cells[38, 3] = txtCBCPlaSmeV.Text;
                //worksheet.Cells[38, 4] = chkCBCPlaSmeN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[39, 2] = txtCBCRbcMorN.Text;
                worksheet.Cells[39, 3] = txtCBCRbcMorV.Text;
                //worksheet.Cells[39, 4] = chkCBCRbcMorN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[40, 2] = txtCBCOtherCN.Text;
                worksheet.Cells[40, 3] = txtCBCOtherCV.Text;
                //worksheet.Cells[40, 4] = chkCBCOtherCN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";

                worksheet.Cells[43, 2] = txtFbsN.Text;
                worksheet.Cells[43, 3] = txtFbsV.Text;
                //worksheet.Cells[43, 4] = chkFbsN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";

                worksheet.Cells[46, 2] = txtCholN.Text;
                worksheet.Cells[46, 3] = txtCholV.Text;
                //worksheet.Cells[46, 4] = chkCholN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";

                worksheet.Cells[49, 2] = txtCreatiN.Text;
                worksheet.Cells[49, 3] = txtCreatiV.Text;
                //worksheet.Cells[49, 4] = chkCreatiN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";

                worksheet.Cells[52, 2] = txtSgotN.Text;
                worksheet.Cells[52, 3] = txtSgotV.Text;
                //worksheet.Cells[52, 4] = chkSgotN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";
                worksheet.Cells[53, 2] = txtSgptN.Text;
                worksheet.Cells[53, 3] = txtSgptV.Text;
                //worksheet.Cells[53, 4] = chkSgptN.Checked ? "ปกติ Normal" : "ผิดปกติ Abnormal";

                //worksheet.Cells[17, 2] = "ส่วนสูง " + txtRhgroup.Text;
                //if (dgvAdd[colDate, i].Value == null)
                //{
                //    worksheet.Cells[i, colDate].Value = "";
                //}
                //else
                //{
                //    visitDate = dgvAdd[colDate, i].Value.ToString();
                //    worksheet.Cells[i, colDate] = visitDate;
                //    visitTime = dgvAdd[colTime, i].Value.ToString();
                //    worksheet.Cells[i, colTime] = visitTime;
                //}
                //err = "002 Dia";
                //if (dgvAdd[colDiaCD2, i].Value == null)
                //{
                //    worksheet.Cells[i, colDiaCD2] = "";
                //}
                //else
                //{
                //    worksheet.Cells[i, colDiaCD2] = config1.stringNull1(dgvAdd[colDiaCD2, i].Value.ToString());
                //}
                //err = "003 Chronic ";
                //worksheet.Cells[i, colDiaCD3] = config1.stringNull1(dgvAdd[colDiaCD3, i].Value);
                //worksheet.Cells[i, colDiaCD4] = config1.stringNull1(dgvAdd[colDiaCD4, i].Value);
                //worksheet.Cells[i, colDiaCD5] = config1.stringNull1(dgvAdd[colDiaCD5, i].Value);

                //worksheet.Cells[i, colCHRONICCODE1] = config1.stringNull1(dgvAdd[colCHRONICCODE1, i].Value);
                //worksheet.Cells[i, colCHRONICCODE2] = config1.stringNull1(dgvAdd[colCHRONICCODE2, i].Value);
                //worksheet.Cells[i, colCHRONICCODE3] = config1.stringNull1(dgvAdd[colCHRONICCODE3, i].Value);
                //worksheet.Cells[i, colCHRONICCODE4] = config1.stringNull1(dgvAdd[colCHRONICCODE4, i].Value);
                //worksheet.Cells[i, colCHRONICCODE5] = config1.stringNull1(dgvAdd[colCHRONICCODE5, i].Value);
                //if (nudChronic.Value <= 5)
                //{
                //    continue;
                //}

                //worksheet.Cells[i, colCHRONICCODE6] = config1.stringNull1(dgvAdd[colCHRONICCODE6, i].Value);
                //worksheet.Cells[i, colCHRONICCODE7] = config1.stringNull1(dgvAdd[colCHRONICCODE7, i].Value);
                //worksheet.Cells[i, colCHRONICCODE8] = config1.stringNull1(dgvAdd[colCHRONICCODE8, i].Value);
                //worksheet.Cells[i, colCHRONICCODE9] = config1.stringNull1(dgvAdd[colCHRONICCODE9, i].Value);
                //worksheet.Cells[i, colCHRONICCODE10] = config1.stringNull1(dgvAdd[colCHRONICCODE10, i].Value);
                //err = "004 Drug ";

                //worksheet.Cells[i, colDrug1] = config1.stringNull1(dgvAdd[colDrug1, i].Value);
                //worksheet.Cells[i, colDrug2] = config1.stringNull1(dgvAdd[colDrug2, i].Value);
                //worksheet.Cells[i, colDrug3] = config1.stringNull1(dgvAdd[colDrug3, i].Value);
                //worksheet.Cells[i, colDrug4] = config1.stringNull1(dgvAdd[colDrug4, i].Value);
                //worksheet.Cells[i, colDrug5] = config1.stringNull1(dgvAdd[colDrug5, i].Value);

                //worksheet.Cells[i, colDrug6] = config1.stringNull1(dgvAdd[colDrug6, i].Value);
                //worksheet.Cells[i, colDrug7] = config1.stringNull1(dgvAdd[colDrug7, i].Value);
                //worksheet.Cells[i, colDrug8] = config1.stringNull1(dgvAdd[colDrug8, i].Value);
                //worksheet.Cells[i, colDrug9] = config1.stringNull1(dgvAdd[colDrug9, i].Value);
                //worksheet.Cells[i, colDrug10] = config1.stringNull1(dgvAdd[colDrug10, i].Value);
                //if (nudDrug.Value <= 10)
                //{
                //    continue;
                //}

                //worksheet.Cells[i, colDrug11] = config1.stringNull1(dgvAdd[colDrug11, i].Value);
                //worksheet.Cells[i, colDrug12] = config1.stringNull1(dgvAdd[colDrug12, i].Value);
                //worksheet.Cells[i, colDrug13] = config1.stringNull1(dgvAdd[colDrug13, i].Value);
                //worksheet.Cells[i, colDrug14] = config1.stringNull1(dgvAdd[colDrug14, i].Value);
                //worksheet.Cells[i, colDrug15] = config1.stringNull1(dgvAdd[colDrug15, i].Value);

                //worksheet.Cells[i, colDrug16] = config1.stringNull1(dgvAdd[colDrug16, i].Value);
                //worksheet.Cells[i, colDrug17] = config1.stringNull1(dgvAdd[colDrug17, i].Value);
                //worksheet.Cells[i, colDrug18] = config1.stringNull1(dgvAdd[colDrug18, i].Value);
                //worksheet.Cells[i, colDrug19] = config1.stringNull1(dgvAdd[colDrug19, i].Value);
                //worksheet.Cells[i, colDrug20] = config1.stringNull1(dgvAdd[colDrug20, i].Value);
                //pB1.Value = i;
            }
            catch (Exception ex)
            {
                    //MessageBox.Show("Error " + ex.Message + "\n row " + i, "error " + err);
            }
            //if (dgvAdd[colPatientHnno, i].Value == null)
            //{
            //    continue;
            //}

            //}


            //worksheet.Cells[1, 1] = "Name";
            //worksheet.Cells[1, 2] = "Bid";

            //worksheet.Cells[2, 1] = txbName.Text;
            //worksheet.Cells[2, 2] = txbResult.Text;
            //pB1.Hide();
            
            excelapp.UserControl = true;
            excelapp.Visible = true;
        }

        private void FrmOPDCheckUP_Load(object sender, EventArgs e)
        {

        }
    }
}
