﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Hoclieu5
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Hoclieu5Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("1aeccf40-9455-4f18-9c90-011a991b6698")]
    public partial class Hoclieu5Repository : RepoGenBaseFolder
    {
        static Hoclieu5Repository instance = new Hoclieu5Repository();
        Hoclieu5RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        Hoclieu5RepositoryFolders.ĐăngNhậpSachMềmAppFolder _đăngnhậpsachmềm;

        /// <summary>
        /// Gets the singleton class instance representing the Hoclieu5Repository element repository.
        /// </summary>
        [RepositoryFolder("1aeccf40-9455-4f18-9c90-011a991b6698")]
        public static Hoclieu5Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Hoclieu5Repository() 
            : base("Hoclieu5Repository", "/", null, 0, false, "1aeccf40-9455-4f18-9c90-011a991b6698", ".\\RepositoryImages\\Hoclieu5Repository1aeccf40.rximgres")
        {
            _applicationundertest = new Hoclieu5RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _đăngnhậpsachmềm = new Hoclieu5RepositoryFolders.ĐăngNhậpSachMềmAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("1aeccf40-9455-4f18-9c90-011a991b6698")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("25e411f6-2d46-4668-a2fb-85b6d89ef646")]
        public virtual Hoclieu5RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The ĐăngNhậpSachMềm folder.
        /// </summary>
        [RepositoryFolder("5cd06933-3b39-448c-8702-a7db3d3ee9f2")]
        public virtual Hoclieu5RepositoryFolders.ĐăngNhậpSachMềmAppFolder ĐăngNhậpSachMềm
        {
            get { return _đăngnhậpsachmềm; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Hoclieu5RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("25e411f6-2d46-4668-a2fb-85b6d89ef646")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            Hoclieu5RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder _httpshoclieusachmemvnquestionset;
            Hoclieu5RepositoryFolders.ContentBoundFolder _contentbound;
            Hoclieu5RepositoryFolders.BsDatepickerThemeGreenFolder _bsdatepickerthemegreen;
            RepoItemInfo _spantag10Info;
            RepoItemInfo _divtagthờigianbắtđầulớnhơnthờigiInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='hoclieu.sachmem.vn']", parentFolder, 30000, null, false, "25e411f6-2d46-4668-a2fb-85b6d89ef646", "")
            {
                _httpshoclieusachmemvnquestionset = new Hoclieu5RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder(this);
                _contentbound = new Hoclieu5RepositoryFolders.ContentBoundFolder(this);
                _bsdatepickerthemegreen = new Hoclieu5RepositoryFolders.BsDatepickerThemeGreenFolder(this);
                _spantag10Info = new RepoItemInfo(this, "SpanTag10", "body//tag[@tagname='bs-calendar-layout']/div[2]/table/tbody/tr[2]/td[7]/span[@innertext='10']", 30000, null, "791ba90d-2445-4e52-8f05-f5420a468263");
                _divtagthờigianbắtđầulớnhơnthờigiInfo = new RepoItemInfo(this, "DivTagThờiGianBắtĐầuLớnHơnThờiGi", ".//div[#'toast-container']/?/?/div[@innertext~'^\\ Thời\\ gian\\ bắt\\ đầu\\ lớn\\ hơ']", 30000, null, "0bc73936-583a-433e-ba75-a53fd2b4e480");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("25e411f6-2d46-4668-a2fb-85b6d89ef646")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("25e411f6-2d46-4668-a2fb-85b6d89ef646")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SpanTag10 item.
            /// </summary>
            [RepositoryItem("791ba90d-2445-4e52-8f05-f5420a468263")]
            public virtual Ranorex.SpanTag SpanTag10
            {
                get
                {
                    return _spantag10Info.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The SpanTag10 item info.
            /// </summary>
            [RepositoryItemInfo("791ba90d-2445-4e52-8f05-f5420a468263")]
            public virtual RepoItemInfo SpanTag10Info
            {
                get
                {
                    return _spantag10Info;
                }
            }

            /// <summary>
            /// The DivTagThờiGianBắtĐầuLớnHơnThờiGi item.
            /// </summary>
            [RepositoryItem("0bc73936-583a-433e-ba75-a53fd2b4e480")]
            public virtual Ranorex.DivTag DivTagThờiGianBắtĐầuLớnHơnThờiGi
            {
                get
                {
                    return _divtagthờigianbắtđầulớnhơnthờigiInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagThờiGianBắtĐầuLớnHơnThờiGi item info.
            /// </summary>
            [RepositoryItemInfo("0bc73936-583a-433e-ba75-a53fd2b4e480")]
            public virtual RepoItemInfo DivTagThờiGianBắtĐầuLớnHơnThờiGiInfo
            {
                get
                {
                    return _divtagthờigianbắtđầulớnhơnthờigiInfo;
                }
            }

            /// <summary>
            /// The HttpsHoclieuSachmemVnQuestionSet folder.
            /// </summary>
            [RepositoryFolder("7538279b-01fc-4da5-9102-d70088b42098")]
            public virtual Hoclieu5RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder HttpsHoclieuSachmemVnQuestionSet
            {
                get { return _httpshoclieusachmemvnquestionset; }
            }

            /// <summary>
            /// The ContentBound folder.
            /// </summary>
            [RepositoryFolder("d2ae31bd-ae3e-44cb-b7c2-0b1f642ac218")]
            public virtual Hoclieu5RepositoryFolders.ContentBoundFolder ContentBound
            {
                get { return _contentbound; }
            }

            /// <summary>
            /// The BsDatepickerThemeGreen folder.
            /// </summary>
            [RepositoryFolder("58d883e4-852d-4a8f-bb9a-a3dbe9d5cca2")]
            public virtual Hoclieu5RepositoryFolders.BsDatepickerThemeGreenFolder BsDatepickerThemeGreen
            {
                get { return _bsdatepickerthemegreen; }
            }
        }

        /// <summary>
        /// The HttpsHoclieuSachmemVnQuestionSetFolder folder.
        /// </summary>
        [RepositoryFolder("7538279b-01fc-4da5-9102-d70088b42098")]
        public partial class HttpsHoclieuSachmemVnQuestionSetFolder : RepoGenBaseFolder
        {
            RepoItemInfo _submitInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _lớplớpInfo;
            RepoItemInfo _nginputInfo;

            /// <summary>
            /// Creates a new HttpsHoclieuSachmemVnQuestionSet  folder.
            /// </summary>
            public HttpsHoclieuSachmemVnQuestionSetFolder(RepoGenBaseFolder parentFolder) :
                    base("HttpsHoclieuSachmemVnQuestionSet", ".//div[#'createAssignmentModal']//form[@action='https://hoclieu.sachmem.vn/question_set/5a4b18b248150cd8b90656fe/5a4b18b248150cd8b9065701/preview']", parentFolder, 30000, null, false, "7538279b-01fc-4da5-9102-d70088b42098", "")
            {
                _submitInfo = new RepoItemInfo(this, "Submit", "?/?/input[@type='submit']", 30000, null, "c5a80c35-a13f-4a89-aa45-3c99de4b9b07");
                _textInfo = new RepoItemInfo(this, "Text", "div[1]/div[10]/?/?/input[@type='text']", 30000, null, "313ac2d7-52a9-4e1a-b7f7-984f43bccdf7");
                _lớplớpInfo = new RepoItemInfo(this, "LớpLớp", "div[1]/div[3]/?/?/tag[@tagname='ng-dropdown-panel']/div/div[2]/?/?/span[@innertext='Lớp lớp']", 30000, null, "3242545e-f13f-48fc-92e0-4cd3c949bdbd");
                _nginputInfo = new RepoItemInfo(this, "NgInput", "div[1]/div[3]/tag[@tagname='ng-select']/div/div/div[2]", 30000, null, "0d689cf0-3719-49b4-bedc-82a2a49aac58");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7538279b-01fc-4da5-9102-d70088b42098")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7538279b-01fc-4da5-9102-d70088b42098")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Submit item.
            /// </summary>
            [RepositoryItem("c5a80c35-a13f-4a89-aa45-3c99de4b9b07")]
            public virtual Ranorex.InputTag Submit
            {
                get
                {
                    return _submitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Submit item info.
            /// </summary>
            [RepositoryItemInfo("c5a80c35-a13f-4a89-aa45-3c99de4b9b07")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("313ac2d7-52a9-4e1a-b7f7-984f43bccdf7")]
            public virtual Ranorex.InputTag Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("313ac2d7-52a9-4e1a-b7f7-984f43bccdf7")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The LớpLớp item.
            /// </summary>
            [RepositoryItem("3242545e-f13f-48fc-92e0-4cd3c949bdbd")]
            public virtual Ranorex.SpanTag LớpLớp
            {
                get
                {
                    return _lớplớpInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The LớpLớp item info.
            /// </summary>
            [RepositoryItemInfo("3242545e-f13f-48fc-92e0-4cd3c949bdbd")]
            public virtual RepoItemInfo LớpLớpInfo
            {
                get
                {
                    return _lớplớpInfo;
                }
            }

            /// <summary>
            /// The NgInput item.
            /// </summary>
            [RepositoryItem("0d689cf0-3719-49b4-bedc-82a2a49aac58")]
            public virtual Ranorex.DivTag NgInput
            {
                get
                {
                    return _nginputInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The NgInput item info.
            /// </summary>
            [RepositoryItemInfo("0d689cf0-3719-49b4-bedc-82a2a49aac58")]
            public virtual RepoItemInfo NgInputInfo
            {
                get
                {
                    return _nginputInfo;
                }
            }
        }

        /// <summary>
        /// The ContentBoundFolder folder.
        /// </summary>
        [RepositoryFolder("d2ae31bd-ae3e-44cb-b7c2-0b1f642ac218")]
        public partial class ContentBoundFolder : RepoGenBaseFolder
        {
            RepoItemInfo _giaobaitậpInfo;
            RepoItemInfo _lớp4Info;
            RepoItemInfo _luyệntậptiếnganh4tập1Info;
            RepoItemInfo _đăngnhậpInfo;
            RepoItemInfo _luyệntậptiếnganh4tập11Info;

            /// <summary>
            /// Creates a new ContentBound  folder.
            /// </summary>
            public ContentBoundFolder(RepoGenBaseFolder parentFolder) :
                    base("ContentBound", "body/tag[@tagname='app-root']/div[2]", parentFolder, 30000, null, false, "d2ae31bd-ae3e-44cb-b7c2-0b1f642ac218", "")
            {
                _giaobaitậpInfo = new RepoItemInfo(this, "GiaoBaiTập", ".//tag[@tagname='question']/div/div[2]/div/?/?/tag[@tagname='app-preview-list-question']/div/div[1]/div[1]/div[2]/a[@href='javascript:void(0)']/span[@innertext='Giao bài tập']", 30000, null, "3009b0ba-0e47-494f-bca5-793ed54a0d2a");
                _lớp4Info = new RepoItemInfo(this, "Lớp4", ".//ul/li[7]/div/div[1]/a[@innertext='Lớp 4']", 30000, null, "3873a450-661b-419b-8b6b-74a60c82620f");
                _luyệntậptiếnganh4tập1Info = new RepoItemInfo(this, "LuyệnTậpTiếngAnh4Tập1", ".//ul/li[7]/div/div[1]/a[@innertext~'^Luyện\\ tập\\ Tiếng\\ Anh\\ 4\\ Tập']", 30000, null, "ebef6053-4d2d-44a8-aa14-c090c88af8f2");
                _đăngnhậpInfo = new RepoItemInfo(this, "ĐăngNhập", "div//div[@innertext~'^\\ \\ Để\\ sử\\ dụng\\ bạn\\ cần\\ \\ ho']/a[@innertext='Đăng nhập']", 30000, null, "34b4e1bf-9b9d-46bc-991f-22e6f379c7f4");
                _luyệntậptiếnganh4tập11Info = new RepoItemInfo(this, "LuyệnTậpTiếngAnh4Tập11", ".//ul/li[5]/div/div[1]/a[@innertext~'^Luyện\\ tập\\ Tiếng\\ Anh\\ 4\\ Tập']", 30000, null, "85b23bb3-4228-4d3d-bd40-0eea46cf86ce");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d2ae31bd-ae3e-44cb-b7c2-0b1f642ac218")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d2ae31bd-ae3e-44cb-b7c2-0b1f642ac218")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The GiaoBaiTập item.
            /// </summary>
            [RepositoryItem("3009b0ba-0e47-494f-bca5-793ed54a0d2a")]
            public virtual Ranorex.SpanTag GiaoBaiTập
            {
                get
                {
                    return _giaobaitậpInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The GiaoBaiTập item info.
            /// </summary>
            [RepositoryItemInfo("3009b0ba-0e47-494f-bca5-793ed54a0d2a")]
            public virtual RepoItemInfo GiaoBaiTậpInfo
            {
                get
                {
                    return _giaobaitậpInfo;
                }
            }

            /// <summary>
            /// The Lớp4 item.
            /// </summary>
            [RepositoryItem("3873a450-661b-419b-8b6b-74a60c82620f")]
            public virtual Ranorex.ATag Lớp4
            {
                get
                {
                    return _lớp4Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Lớp4 item info.
            /// </summary>
            [RepositoryItemInfo("3873a450-661b-419b-8b6b-74a60c82620f")]
            public virtual RepoItemInfo Lớp4Info
            {
                get
                {
                    return _lớp4Info;
                }
            }

            /// <summary>
            /// The LuyệnTậpTiếngAnh4Tập1 item.
            /// </summary>
            [RepositoryItem("ebef6053-4d2d-44a8-aa14-c090c88af8f2")]
            public virtual Ranorex.ATag LuyệnTậpTiếngAnh4Tập1
            {
                get
                {
                    return _luyệntậptiếnganh4tập1Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LuyệnTậpTiếngAnh4Tập1 item info.
            /// </summary>
            [RepositoryItemInfo("ebef6053-4d2d-44a8-aa14-c090c88af8f2")]
            public virtual RepoItemInfo LuyệnTậpTiếngAnh4Tập1Info
            {
                get
                {
                    return _luyệntậptiếnganh4tập1Info;
                }
            }

            /// <summary>
            /// The ĐăngNhập item.
            /// </summary>
            [RepositoryItem("34b4e1bf-9b9d-46bc-991f-22e6f379c7f4")]
            public virtual Ranorex.ATag ĐăngNhập
            {
                get
                {
                    return _đăngnhậpInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ĐăngNhập item info.
            /// </summary>
            [RepositoryItemInfo("34b4e1bf-9b9d-46bc-991f-22e6f379c7f4")]
            public virtual RepoItemInfo ĐăngNhậpInfo
            {
                get
                {
                    return _đăngnhậpInfo;
                }
            }

            /// <summary>
            /// The LuyệnTậpTiếngAnh4Tập11 item.
            /// </summary>
            [RepositoryItem("85b23bb3-4228-4d3d-bd40-0eea46cf86ce")]
            public virtual Ranorex.ATag LuyệnTậpTiếngAnh4Tập11
            {
                get
                {
                    return _luyệntậptiếnganh4tập11Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LuyệnTậpTiếngAnh4Tập11 item info.
            /// </summary>
            [RepositoryItemInfo("85b23bb3-4228-4d3d-bd40-0eea46cf86ce")]
            public virtual RepoItemInfo LuyệnTậpTiếngAnh4Tập11Info
            {
                get
                {
                    return _luyệntậptiếnganh4tập11Info;
                }
            }
        }

        /// <summary>
        /// The BsDatepickerThemeGreenFolder folder.
        /// </summary>
        [RepositoryFolder("58d883e4-852d-4a8f-bb9a-a3dbe9d5cca2")]
        public partial class BsDatepickerThemeGreenFolder : RepoGenBaseFolder
        {
            RepoItemInfo _aprilInfo;
            RepoItemInfo _spantag2020Info;
            RepoItemInfo _spantag2019Info;

            /// <summary>
            /// Creates a new BsDatepickerThemeGreen  folder.
            /// </summary>
            public BsDatepickerThemeGreenFolder(RepoGenBaseFolder parentFolder) :
                    base("BsDatepickerThemeGreen", "body/tag[@tagname='bs-datepicker-container']/div", parentFolder, 30000, null, false, "58d883e4-852d-4a8f-bb9a-a3dbe9d5cca2", "")
            {
                _aprilInfo = new RepoItemInfo(this, "April", ".//tag[@tagname='bs-calendar-layout']/div[2]/table/tbody/tr[2]/td[1]/span[@innertext='April']", 30000, null, "180ee57d-eb2b-4605-953f-27c2ec4fe1fd");
                _spantag2020Info = new RepoItemInfo(this, "SpanTag2020", ".//tag[@tagname='bs-calendar-layout']/div[2]/table/tbody/tr[3]/td[1]/span[@innertext='2020']", 30000, null, "2a38ab77-2411-4a1a-8fe5-fbef861128af");
                _spantag2019Info = new RepoItemInfo(this, "SpanTag2019", "div//tag[@tagname='bs-calendar-layout']/div[1]/tag/button[3]/span[@innertext='2019']", 30000, null, "2463f50c-d606-44ae-af7a-dbe782dce3e7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("58d883e4-852d-4a8f-bb9a-a3dbe9d5cca2")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("58d883e4-852d-4a8f-bb9a-a3dbe9d5cca2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The April item.
            /// </summary>
            [RepositoryItem("180ee57d-eb2b-4605-953f-27c2ec4fe1fd")]
            public virtual Ranorex.SpanTag April
            {
                get
                {
                    return _aprilInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The April item info.
            /// </summary>
            [RepositoryItemInfo("180ee57d-eb2b-4605-953f-27c2ec4fe1fd")]
            public virtual RepoItemInfo AprilInfo
            {
                get
                {
                    return _aprilInfo;
                }
            }

            /// <summary>
            /// The SpanTag2020 item.
            /// </summary>
            [RepositoryItem("2a38ab77-2411-4a1a-8fe5-fbef861128af")]
            public virtual Ranorex.SpanTag SpanTag2020
            {
                get
                {
                    return _spantag2020Info.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The SpanTag2020 item info.
            /// </summary>
            [RepositoryItemInfo("2a38ab77-2411-4a1a-8fe5-fbef861128af")]
            public virtual RepoItemInfo SpanTag2020Info
            {
                get
                {
                    return _spantag2020Info;
                }
            }

            /// <summary>
            /// The SpanTag2019 item.
            /// </summary>
            [RepositoryItem("2463f50c-d606-44ae-af7a-dbe782dce3e7")]
            public virtual Ranorex.SpanTag SpanTag2019
            {
                get
                {
                    return _spantag2019Info.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The SpanTag2019 item info.
            /// </summary>
            [RepositoryItemInfo("2463f50c-d606-44ae-af7a-dbe782dce3e7")]
            public virtual RepoItemInfo SpanTag2019Info
            {
                get
                {
                    return _spantag2019Info;
                }
            }
        }

        /// <summary>
        /// The ĐăngNhậpSachMềmAppFolder folder.
        /// </summary>
        [RepositoryFolder("5cd06933-3b39-448c-8702-a7db3d3ee9f2")]
        public partial class ĐăngNhậpSachMềmAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _commitInfo;

            /// <summary>
            /// Creates a new ĐăngNhậpSachMềm  folder.
            /// </summary>
            public ĐăngNhậpSachMềmAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ĐăngNhậpSachMềm", "/dom[@domain='accounts.sachmem.vn']", parentFolder, 30000, null, false, "5cd06933-3b39-448c-8702-a7db3d3ee9f2", "")
            {
                _commitInfo = new RepoItemInfo(this, "Commit", ".//form[#'new_user']/?/?/input[@name='commit']", 30000, null, "f2cf3ac5-add3-4317-9299-7639e0c431aa");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5cd06933-3b39-448c-8702-a7db3d3ee9f2")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5cd06933-3b39-448c-8702-a7db3d3ee9f2")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Commit item.
            /// </summary>
            [RepositoryItem("f2cf3ac5-add3-4317-9299-7639e0c431aa")]
            public virtual Ranorex.InputTag Commit
            {
                get
                {
                    return _commitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Commit item info.
            /// </summary>
            [RepositoryItemInfo("f2cf3ac5-add3-4317-9299-7639e0c431aa")]
            public virtual RepoItemInfo CommitInfo
            {
                get
                {
                    return _commitInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
