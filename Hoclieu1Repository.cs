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

namespace Hoclieu1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Hoclieu1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("1699c620-ab87-4677-9168-002d3043a8e2")]
    public partial class Hoclieu1Repository : RepoGenBaseFolder
    {
        static Hoclieu1Repository instance = new Hoclieu1Repository();
        Hoclieu1RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        Hoclieu1RepositoryFolders.HọcLiệuSachMềmGoogleChromeAppFolder _họcliệusachmềmgooglechrome;
        Hoclieu1RepositoryFolders.Motmi98TestingGoogleChromeAppFolder _motmi98testinggooglechrome;
        Hoclieu1RepositoryFolders.ĐăngNhậpSachMềmAppFolder _đăngnhậpsachmềm;

        /// <summary>
        /// Gets the singleton class instance representing the Hoclieu1Repository element repository.
        /// </summary>
        [RepositoryFolder("1699c620-ab87-4677-9168-002d3043a8e2")]
        public static Hoclieu1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Hoclieu1Repository() 
            : base("Hoclieu1Repository", "/", null, 0, false, "1699c620-ab87-4677-9168-002d3043a8e2", ".\\RepositoryImages\\Hoclieu1Repository1699c620.rximgres")
        {
            _applicationundertest = new Hoclieu1RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _họcliệusachmềmgooglechrome = new Hoclieu1RepositoryFolders.HọcLiệuSachMềmGoogleChromeAppFolder(this);
            _motmi98testinggooglechrome = new Hoclieu1RepositoryFolders.Motmi98TestingGoogleChromeAppFolder(this);
            _đăngnhậpsachmềm = new Hoclieu1RepositoryFolders.ĐăngNhậpSachMềmAppFolder(this);
        }

#region Variables

        string _Redos = "-1";

        /// <summary>
        /// Gets or sets the value of variable Redos.
        /// </summary>
        [TestVariable("b18b2178-79f6-4b4f-83df-c856b9227afd")]
        public string Redos
        {
            get { return _Redos; }
            set { _Redos = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("1699c620-ab87-4677-9168-002d3043a8e2")]
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
        [RepositoryFolder("c6899e6f-b74a-4c3c-8e49-11d7b5cf091e")]
        public virtual Hoclieu1RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The HọcLiệuSachMềmGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("c54823a3-f2b1-4891-9471-f2f09ead2ff3")]
        public virtual Hoclieu1RepositoryFolders.HọcLiệuSachMềmGoogleChromeAppFolder HọcLiệuSachMềmGoogleChrome
        {
            get { return _họcliệusachmềmgooglechrome; }
        }

        /// <summary>
        /// The Motmi98TestingGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("83c19510-87c0-4881-8a8b-2d700aa32023")]
        public virtual Hoclieu1RepositoryFolders.Motmi98TestingGoogleChromeAppFolder Motmi98TestingGoogleChrome
        {
            get { return _motmi98testinggooglechrome; }
        }

        /// <summary>
        /// The ĐăngNhậpSachMềm folder.
        /// </summary>
        [RepositoryFolder("d72b865b-6f40-46d7-9e79-2b9f04d577f8")]
        public virtual Hoclieu1RepositoryFolders.ĐăngNhậpSachMềmAppFolder ĐăngNhậpSachMềm
        {
            get { return _đăngnhậpsachmềm; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Hoclieu1RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("c6899e6f-b74a-4c3c-8e49-11d7b5cf091e")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            Hoclieu1RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder _httpshoclieusachmemvnquestionset;
            Hoclieu1RepositoryFolders.ContentBoundFolder _contentbound;
            RepoItemInfo _divtaggiaobaitậpthanhcongInfo;
            RepoItemInfo _divtagsốlầnlamlạiphảilớnhơnhoặcInfo;
            RepoItemInfo _divtagmathamgiakhongđungInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='hoclieu.sachmem.vn']", parentFolder, 30000, null, false, "c6899e6f-b74a-4c3c-8e49-11d7b5cf091e", "")
            {
                _httpshoclieusachmemvnquestionset = new Hoclieu1RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder(this);
                _contentbound = new Hoclieu1RepositoryFolders.ContentBoundFolder(this);
                _divtaggiaobaitậpthanhcongInfo = new RepoItemInfo(this, "DivTagGiaoBaiTậpThanhCong", ".//div[#'toast-container']/?/?/div[@innertext=' Giao bài tập thành công ']", 30000, null, "8837bfd1-0ba0-434a-8a77-c25012e24c55");
                _divtagsốlầnlamlạiphảilớnhơnhoặcInfo = new RepoItemInfo(this, "DivTagSốLầnLamLạiPhảiLớnHơnHoặc", ".//div[#'toast-container']/?/?/div[@innertext~'^\\ Số\\ lần\\ làm\\ lại\\ phải\\ lớn\\ ']", 30000, null, "12a5ef4a-63e7-4c28-b99d-0f6a48083039");
                _divtagmathamgiakhongđungInfo = new RepoItemInfo(this, "DivTagMaThamGiaKhongĐung", ".//div[#'toast-container']/?/?/div[@innertext=' Mã tham gia không đúng ']", 30000, null, "b3ce42cc-6a89-45b0-bf77-f37973bb9469");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c6899e6f-b74a-4c3c-8e49-11d7b5cf091e")]
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
            [RepositoryItemInfo("c6899e6f-b74a-4c3c-8e49-11d7b5cf091e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The DivTagGiaoBaiTậpThanhCong item.
            /// </summary>
            [RepositoryItem("8837bfd1-0ba0-434a-8a77-c25012e24c55")]
            public virtual Ranorex.DivTag DivTagGiaoBaiTậpThanhCong
            {
                get
                {
                    return _divtaggiaobaitậpthanhcongInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagGiaoBaiTậpThanhCong item info.
            /// </summary>
            [RepositoryItemInfo("8837bfd1-0ba0-434a-8a77-c25012e24c55")]
            public virtual RepoItemInfo DivTagGiaoBaiTậpThanhCongInfo
            {
                get
                {
                    return _divtaggiaobaitậpthanhcongInfo;
                }
            }

            /// <summary>
            /// The DivTagSốLầnLamLạiPhảiLớnHơnHoặc item.
            /// </summary>
            [RepositoryItem("12a5ef4a-63e7-4c28-b99d-0f6a48083039")]
            public virtual Ranorex.DivTag DivTagSốLầnLamLạiPhảiLớnHơnHoặc
            {
                get
                {
                    return _divtagsốlầnlamlạiphảilớnhơnhoặcInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagSốLầnLamLạiPhảiLớnHơnHoặc item info.
            /// </summary>
            [RepositoryItemInfo("12a5ef4a-63e7-4c28-b99d-0f6a48083039")]
            public virtual RepoItemInfo DivTagSốLầnLamLạiPhảiLớnHơnHoặcInfo
            {
                get
                {
                    return _divtagsốlầnlamlạiphảilớnhơnhoặcInfo;
                }
            }

            /// <summary>
            /// The DivTagMaThamGiaKhongĐung item.
            /// </summary>
            [RepositoryItem("b3ce42cc-6a89-45b0-bf77-f37973bb9469")]
            public virtual Ranorex.DivTag DivTagMaThamGiaKhongĐung
            {
                get
                {
                    return _divtagmathamgiakhongđungInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagMaThamGiaKhongĐung item info.
            /// </summary>
            [RepositoryItemInfo("b3ce42cc-6a89-45b0-bf77-f37973bb9469")]
            public virtual RepoItemInfo DivTagMaThamGiaKhongĐungInfo
            {
                get
                {
                    return _divtagmathamgiakhongđungInfo;
                }
            }

            /// <summary>
            /// The HttpsHoclieuSachmemVnQuestionSet folder.
            /// </summary>
            [RepositoryFolder("bf62a29f-77f3-4db3-ab70-feb2fafadf9c")]
            public virtual Hoclieu1RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder HttpsHoclieuSachmemVnQuestionSet
            {
                get { return _httpshoclieusachmemvnquestionset; }
            }

            /// <summary>
            /// The ContentBound folder.
            /// </summary>
            [RepositoryFolder("18ba4499-efb0-4f58-bb06-35160a168ef4")]
            public virtual Hoclieu1RepositoryFolders.ContentBoundFolder ContentBound
            {
                get { return _contentbound; }
            }
        }

        /// <summary>
        /// The HttpsHoclieuSachmemVnQuestionSetFolder folder.
        /// </summary>
        [RepositoryFolder("bf62a29f-77f3-4db3-ab70-feb2fafadf9c")]
        public partial class HttpsHoclieuSachmemVnQuestionSetFolder : RepoGenBaseFolder
        {
            RepoItemInfo _submitInfo;
            RepoItemInfo _ngoptionngoptionmarkedngstarinserInfo;
            RepoItemInfo _nginputInfo;
            RepoItemInfo _numberInfo;
            RepoItemInfo _nginput1Info;
            RepoItemInfo _lớplớpInfo;

            /// <summary>
            /// Creates a new HttpsHoclieuSachmemVnQuestionSet  folder.
            /// </summary>
            public HttpsHoclieuSachmemVnQuestionSetFolder(RepoGenBaseFolder parentFolder) :
                    base("HttpsHoclieuSachmemVnQuestionSet", ".//div[#'createAssignmentModal']//form[@action='https://hoclieu.sachmem.vn/question_set/5a4b18b248150cd8b90656fe/5a4b18b248150cd8b9065701/preview']", parentFolder, 30000, null, false, "bf62a29f-77f3-4db3-ab70-feb2fafadf9c", "")
            {
                _submitInfo = new RepoItemInfo(this, "Submit", "?/?/input[@type='submit']", 30000, null, "ba993643-62ee-41d5-939e-b8f1ae49a7cb");
                _ngoptionngoptionmarkedngstarinserInfo = new RepoItemInfo(this, "NgOptionNgOptionMarkedNgStarInser", "div[1]/div[3]/?/?/tag[@tagname='ng-dropdown-panel']/div/div[2]/div", 30000, null, "e6985073-d173-47c9-a03d-55affcb7940a");
                _nginputInfo = new RepoItemInfo(this, "NgInput", "div[1]/div[3]/tag[@tagname='ng-select']/div/div/div[2]", 30000, null, "4d59b4b1-0cc4-47e6-bb12-38c3f3c7293d");
                _numberInfo = new RepoItemInfo(this, "Number", "div[1]/div[7]/input[@type='number']", 30000, null, "84888536-3e1c-40d8-ab50-3296c54cdf68");
                _nginput1Info = new RepoItemInfo(this, "NgInput1", "div[1]/div[3]/tag[@tagname='ng-select']/div/div/div[3]", 30000, null, "87debd7c-9dbb-4877-af17-12be85e4a148");
                _lớplớpInfo = new RepoItemInfo(this, "LớpLớp", "div[1]/div[3]/?/?/tag[@tagname='ng-dropdown-panel']/div/div[2]/?/?/span[@innertext='Lớp lớp']", 30000, null, "a7162121-a55e-47a7-885b-c15a77585c0d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bf62a29f-77f3-4db3-ab70-feb2fafadf9c")]
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
            [RepositoryItemInfo("bf62a29f-77f3-4db3-ab70-feb2fafadf9c")]
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
            [RepositoryItem("ba993643-62ee-41d5-939e-b8f1ae49a7cb")]
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
            [RepositoryItemInfo("ba993643-62ee-41d5-939e-b8f1ae49a7cb")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }

            /// <summary>
            /// The NgOptionNgOptionMarkedNgStarInser item.
            /// </summary>
            [RepositoryItem("e6985073-d173-47c9-a03d-55affcb7940a")]
            public virtual Ranorex.DivTag NgOptionNgOptionMarkedNgStarInser
            {
                get
                {
                    return _ngoptionngoptionmarkedngstarinserInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The NgOptionNgOptionMarkedNgStarInser item info.
            /// </summary>
            [RepositoryItemInfo("e6985073-d173-47c9-a03d-55affcb7940a")]
            public virtual RepoItemInfo NgOptionNgOptionMarkedNgStarInserInfo
            {
                get
                {
                    return _ngoptionngoptionmarkedngstarinserInfo;
                }
            }

            /// <summary>
            /// The NgInput item.
            /// </summary>
            [RepositoryItem("4d59b4b1-0cc4-47e6-bb12-38c3f3c7293d")]
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
            [RepositoryItemInfo("4d59b4b1-0cc4-47e6-bb12-38c3f3c7293d")]
            public virtual RepoItemInfo NgInputInfo
            {
                get
                {
                    return _nginputInfo;
                }
            }

            /// <summary>
            /// The Number item.
            /// </summary>
            [RepositoryItem("84888536-3e1c-40d8-ab50-3296c54cdf68")]
            public virtual Ranorex.InputTag Number
            {
                get
                {
                    return _numberInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Number item info.
            /// </summary>
            [RepositoryItemInfo("84888536-3e1c-40d8-ab50-3296c54cdf68")]
            public virtual RepoItemInfo NumberInfo
            {
                get
                {
                    return _numberInfo;
                }
            }

            /// <summary>
            /// The NgInput1 item.
            /// </summary>
            [RepositoryItem("87debd7c-9dbb-4877-af17-12be85e4a148")]
            public virtual Ranorex.DivTag NgInput1
            {
                get
                {
                    return _nginput1Info.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The NgInput1 item info.
            /// </summary>
            [RepositoryItemInfo("87debd7c-9dbb-4877-af17-12be85e4a148")]
            public virtual RepoItemInfo NgInput1Info
            {
                get
                {
                    return _nginput1Info;
                }
            }

            /// <summary>
            /// The LớpLớp item.
            /// </summary>
            [RepositoryItem("a7162121-a55e-47a7-885b-c15a77585c0d")]
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
            [RepositoryItemInfo("a7162121-a55e-47a7-885b-c15a77585c0d")]
            public virtual RepoItemInfo LớpLớpInfo
            {
                get
                {
                    return _lớplớpInfo;
                }
            }
        }

        /// <summary>
        /// The ContentBoundFolder folder.
        /// </summary>
        [RepositoryFolder("18ba4499-efb0-4f58-bb06-35160a168ef4")]
        public partial class ContentBoundFolder : RepoGenBaseFolder
        {
            RepoItemInfo _giaobaitậpInfo;
            RepoItemInfo _lớp4Info;
            RepoItemInfo _luyệntậptiếnganh4tập1Info;
            RepoItemInfo _applistclassInfo;
            RepoItemInfo _atagthamgialớpInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _submitInfo;
            RepoItemInfo _lớphọccủatoiInfo;
            RepoItemInfo _lớplớpInfo;
            RepoItemInfo _đăngnhậpInfo;
            RepoItemInfo _divtagmathamgialớphọcInfo;

            /// <summary>
            /// Creates a new ContentBound  folder.
            /// </summary>
            public ContentBoundFolder(RepoGenBaseFolder parentFolder) :
                    base("ContentBound", "body/tag[@tagname='app-root']/div[2]", parentFolder, 30000, null, false, "18ba4499-efb0-4f58-bb06-35160a168ef4", "")
            {
                _giaobaitậpInfo = new RepoItemInfo(this, "GiaoBaiTập", ".//tag[@tagname='question']/div/div[2]/div/?/?/tag[@tagname='app-preview-list-question']/div/div[1]/div[1]/div[2]/a[@href='javascript:void(0)']/span[@innertext='Giao bài tập']", 30000, null, "fe297bec-1b56-4665-804c-153c5f5141ad");
                _lớp4Info = new RepoItemInfo(this, "Lớp4", ".//ul/li[7]/div/div[1]/a[@innertext='Lớp 4']", 30000, null, "f41adaff-e14d-4043-8b7a-be1161d7e3df");
                _luyệntậptiếnganh4tập1Info = new RepoItemInfo(this, "LuyệnTậpTiếngAnh4Tập1", ".//ul/li[7]/div/div[1]/a[@innertext~'^Luyện\\ tập\\ Tiếng\\ Anh\\ 4\\ Tập']", 30000, null, "e93f0a30-bb5f-42c7-ac30-a27ef0f453c0");
                _applistclassInfo = new RepoItemInfo(this, "AppListClass", "div//tag[@tagname='app-list-class']", 30000, null, "e226fac7-562d-4c22-8a34-3406d852fc65");
                _atagthamgialớpInfo = new RepoItemInfo(this, "ATagThamGiaLớp", "div//tag[@tagname='app-list-class']/div[1]/?/?/a[@innertext=' Tham gia lớp...    ']", 30000, null, "a44e3067-5266-4c1e-a633-0a1b9ad17caa");
                _textInfo = new RepoItemInfo(this, "Text", ".//form[@action='https://hoclieu.sachmem.vn/live_class/classes']/div[1]/?/?/input[@type='text']", 30000, null, "e2fc217a-bea8-4d6c-bf6a-ea5f96c46656");
                _submitInfo = new RepoItemInfo(this, "Submit", ".//form[@action='https://hoclieu.sachmem.vn/live_class/classes']/?/?/input[@type='submit']", 30000, null, "fc4e94cb-fdcc-4c76-916c-830fbc8fe9dc");
                _lớphọccủatoiInfo = new RepoItemInfo(this, "LớpHọcCủaToi", "div/div//ul/li[1]//a[@innertext='Lớp học của tôi']", 30000, null, "fc026c7f-f369-4f08-b53a-35a7ec1b7c9e");
                _lớplớpInfo = new RepoItemInfo(this, "LớpLớp", "div//tag[@tagname='app-list-class']/ul[1]/li/div/div[1]/a[@innertext='Lớp lớp']", 30000, null, "679cd1be-7fd5-4cdb-bc3b-685c4f111efb");
                _đăngnhậpInfo = new RepoItemInfo(this, "ĐăngNhập", "div//div[@innertext~'^\\ \\ Để\\ sử\\ dụng\\ bạn\\ cần\\ \\ ho']/a[@innertext='Đăng nhập']", 30000, null, "54539b0a-6df8-4579-a80e-1004623a22b4");
                _divtagmathamgialớphọcInfo = new RepoItemInfo(this, "DivTagMaThamGiaLớpHọc", "div//tag[@tagname='app-action']/div/div[1]/div[@innertext=' Mã tham gia lớp học    ']", 30000, null, "edbc93e4-6d3b-4281-95b5-e422624fe3c6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("18ba4499-efb0-4f58-bb06-35160a168ef4")]
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
            [RepositoryItemInfo("18ba4499-efb0-4f58-bb06-35160a168ef4")]
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
            [RepositoryItem("fe297bec-1b56-4665-804c-153c5f5141ad")]
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
            [RepositoryItemInfo("fe297bec-1b56-4665-804c-153c5f5141ad")]
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
            [RepositoryItem("f41adaff-e14d-4043-8b7a-be1161d7e3df")]
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
            [RepositoryItemInfo("f41adaff-e14d-4043-8b7a-be1161d7e3df")]
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
            [RepositoryItem("e93f0a30-bb5f-42c7-ac30-a27ef0f453c0")]
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
            [RepositoryItemInfo("e93f0a30-bb5f-42c7-ac30-a27ef0f453c0")]
            public virtual RepoItemInfo LuyệnTậpTiếngAnh4Tập1Info
            {
                get
                {
                    return _luyệntậptiếnganh4tập1Info;
                }
            }

            /// <summary>
            /// The AppListClass item.
            /// </summary>
            [RepositoryItem("e226fac7-562d-4c22-8a34-3406d852fc65")]
            public virtual Ranorex.WebElement AppListClass
            {
                get
                {
                    return _applistclassInfo.CreateAdapter<Ranorex.WebElement>(true);
                }
            }

            /// <summary>
            /// The AppListClass item info.
            /// </summary>
            [RepositoryItemInfo("e226fac7-562d-4c22-8a34-3406d852fc65")]
            public virtual RepoItemInfo AppListClassInfo
            {
                get
                {
                    return _applistclassInfo;
                }
            }

            /// <summary>
            /// The ATagThamGiaLớp item.
            /// </summary>
            [RepositoryItem("a44e3067-5266-4c1e-a633-0a1b9ad17caa")]
            public virtual Ranorex.ATag ATagThamGiaLớp
            {
                get
                {
                    return _atagthamgialớpInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ATagThamGiaLớp item info.
            /// </summary>
            [RepositoryItemInfo("a44e3067-5266-4c1e-a633-0a1b9ad17caa")]
            public virtual RepoItemInfo ATagThamGiaLớpInfo
            {
                get
                {
                    return _atagthamgialớpInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("e2fc217a-bea8-4d6c-bf6a-ea5f96c46656")]
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
            [RepositoryItemInfo("e2fc217a-bea8-4d6c-bf6a-ea5f96c46656")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The Submit item.
            /// </summary>
            [RepositoryItem("fc4e94cb-fdcc-4c76-916c-830fbc8fe9dc")]
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
            [RepositoryItemInfo("fc4e94cb-fdcc-4c76-916c-830fbc8fe9dc")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }

            /// <summary>
            /// The LớpHọcCủaToi item.
            /// </summary>
            [RepositoryItem("fc026c7f-f369-4f08-b53a-35a7ec1b7c9e")]
            public virtual Ranorex.ATag LớpHọcCủaToi
            {
                get
                {
                    return _lớphọccủatoiInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LớpHọcCủaToi item info.
            /// </summary>
            [RepositoryItemInfo("fc026c7f-f369-4f08-b53a-35a7ec1b7c9e")]
            public virtual RepoItemInfo LớpHọcCủaToiInfo
            {
                get
                {
                    return _lớphọccủatoiInfo;
                }
            }

            /// <summary>
            /// The LớpLớp item.
            /// </summary>
            [RepositoryItem("679cd1be-7fd5-4cdb-bc3b-685c4f111efb")]
            public virtual Ranorex.ATag LớpLớp
            {
                get
                {
                    return _lớplớpInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LớpLớp item info.
            /// </summary>
            [RepositoryItemInfo("679cd1be-7fd5-4cdb-bc3b-685c4f111efb")]
            public virtual RepoItemInfo LớpLớpInfo
            {
                get
                {
                    return _lớplớpInfo;
                }
            }

            /// <summary>
            /// The ĐăngNhập item.
            /// </summary>
            [RepositoryItem("54539b0a-6df8-4579-a80e-1004623a22b4")]
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
            [RepositoryItemInfo("54539b0a-6df8-4579-a80e-1004623a22b4")]
            public virtual RepoItemInfo ĐăngNhậpInfo
            {
                get
                {
                    return _đăngnhậpInfo;
                }
            }

            /// <summary>
            /// The DivTagMaThamGiaLớpHọc item.
            /// </summary>
            [RepositoryItem("edbc93e4-6d3b-4281-95b5-e422624fe3c6")]
            public virtual Ranorex.DivTag DivTagMaThamGiaLớpHọc
            {
                get
                {
                    return _divtagmathamgialớphọcInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagMaThamGiaLớpHọc item info.
            /// </summary>
            [RepositoryItemInfo("edbc93e4-6d3b-4281-95b5-e422624fe3c6")]
            public virtual RepoItemInfo DivTagMaThamGiaLớpHọcInfo
            {
                get
                {
                    return _divtagmathamgialớphọcInfo;
                }
            }
        }

        /// <summary>
        /// The HọcLiệuSachMềmGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("c54823a3-f2b1-4891-9471-f2f09ead2ff3")]
        public partial class HọcLiệuSachMềmGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _backInfo;

            /// <summary>
            /// Creates a new HọcLiệuSachMềmGoogleChrome  folder.
            /// </summary>
            public HọcLiệuSachMềmGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("HọcLiệuSachMềmGoogleChrome", "/form[@title~'^Học\\ liệu\\ -\\ Sách\\ Mềm\\ -\\ Goo']", parentFolder, 30000, null, true, "c54823a3-f2b1-4891-9471-f2f09ead2ff3", "")
            {
                _backInfo = new RepoItemInfo(this, "Back", "container[@accessiblename~'^Học\\ liệu\\ -\\ Sách\\ Mềm\\ -\\ Goo']/container[@accessiblename='Google Chrome']//button[@accessiblename='Back']", 30000, null, "0bdefd70-a967-4116-94f9-85c80652aec1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c54823a3-f2b1-4891-9471-f2f09ead2ff3")]
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
            [RepositoryItemInfo("c54823a3-f2b1-4891-9471-f2f09ead2ff3")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Back item.
            /// </summary>
            [RepositoryItem("0bdefd70-a967-4116-94f9-85c80652aec1")]
            public virtual Ranorex.Button Back
            {
                get
                {
                    return _backInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Back item info.
            /// </summary>
            [RepositoryItemInfo("0bdefd70-a967-4116-94f9-85c80652aec1")]
            public virtual RepoItemInfo BackInfo
            {
                get
                {
                    return _backInfo;
                }
            }
        }

        /// <summary>
        /// The Motmi98TestingGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("83c19510-87c0-4881-8a8b-2d700aa32023")]
        public partial class Motmi98TestingGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _họcliệusachmềmInfo;
            RepoItemInfo _baitậpthựchanhkiểmthửmonint31172Info;

            /// <summary>
            /// Creates a new Motmi98TestingGoogleChrome  folder.
            /// </summary>
            public Motmi98TestingGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Motmi98TestingGoogleChrome", "/form[@title~'^motmi98/Testing\\ -\\ Google\\ ']", parentFolder, 30000, null, true, "83c19510-87c0-4881-8a8b-2d700aa32023", "")
            {
                _họcliệusachmềmInfo = new RepoItemInfo(this, "HọcLiệuSachMềm", "container[@accessiblename~'^motmi98/Testing\\ -\\ Google\\ ']/container[@accessiblename='Google Chrome']//tabpage[@accessiblename='Học liệu - Sách Mềm']", 30000, null, "4d9284b5-a0fc-4137-9bec-244e21666aaf");
                _baitậpthựchanhkiểmthửmonint31172Info = new RepoItemInfo(this, "BaiTậpThựcHanhKiểmThửMonINT31172", "container[@accessiblename~'^Học\\ liệu\\ -\\ Sách\\ Mềm\\ -\\ Goo']/container[@accessiblename='Google Chrome']//tabpage[@accessiblename~'^Bài\\ tập\\ thực\\ hành\\ kiểm\\ th']", 30000, null, "87a72b9a-e5ae-4844-8fed-91bdbfd45d03");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("83c19510-87c0-4881-8a8b-2d700aa32023")]
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
            [RepositoryItemInfo("83c19510-87c0-4881-8a8b-2d700aa32023")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The HọcLiệuSachMềm item.
            /// </summary>
            [RepositoryItem("4d9284b5-a0fc-4137-9bec-244e21666aaf")]
            public virtual Ranorex.TabPage HọcLiệuSachMềm
            {
                get
                {
                    return _họcliệusachmềmInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The HọcLiệuSachMềm item info.
            /// </summary>
            [RepositoryItemInfo("4d9284b5-a0fc-4137-9bec-244e21666aaf")]
            public virtual RepoItemInfo HọcLiệuSachMềmInfo
            {
                get
                {
                    return _họcliệusachmềmInfo;
                }
            }

            /// <summary>
            /// The BaiTậpThựcHanhKiểmThửMonINT31172 item.
            /// </summary>
            [RepositoryItem("87a72b9a-e5ae-4844-8fed-91bdbfd45d03")]
            public virtual Ranorex.TabPage BaiTậpThựcHanhKiểmThửMonINT31172
            {
                get
                {
                    return _baitậpthựchanhkiểmthửmonint31172Info.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The BaiTậpThựcHanhKiểmThửMonINT31172 item info.
            /// </summary>
            [RepositoryItemInfo("87a72b9a-e5ae-4844-8fed-91bdbfd45d03")]
            public virtual RepoItemInfo BaiTậpThựcHanhKiểmThửMonINT31172Info
            {
                get
                {
                    return _baitậpthựchanhkiểmthửmonint31172Info;
                }
            }
        }

        /// <summary>
        /// The ĐăngNhậpSachMềmAppFolder folder.
        /// </summary>
        [RepositoryFolder("d72b865b-6f40-46d7-9e79-2b9f04d577f8")]
        public partial class ĐăngNhậpSachMềmAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _commitInfo;

            /// <summary>
            /// Creates a new ĐăngNhậpSachMềm  folder.
            /// </summary>
            public ĐăngNhậpSachMềmAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ĐăngNhậpSachMềm", "/dom[@domain='accounts.sachmem.vn']", parentFolder, 30000, null, false, "d72b865b-6f40-46d7-9e79-2b9f04d577f8", "")
            {
                _commitInfo = new RepoItemInfo(this, "Commit", ".//form[#'new_user']/?/?/input[@name='commit']", 30000, null, "9ce4ee86-56d0-4c66-b908-295c30c1cd32");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d72b865b-6f40-46d7-9e79-2b9f04d577f8")]
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
            [RepositoryItemInfo("d72b865b-6f40-46d7-9e79-2b9f04d577f8")]
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
            [RepositoryItem("9ce4ee86-56d0-4c66-b908-295c30c1cd32")]
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
            [RepositoryItemInfo("9ce4ee86-56d0-4c66-b908-295c30c1cd32")]
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
