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

namespace Hoclieu3
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Hoclieu3Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("e6a46bcb-6618-4297-80ee-7a8cbf41fc2f")]
    public partial class Hoclieu3Repository : RepoGenBaseFolder
    {
        static Hoclieu3Repository instance = new Hoclieu3Repository();
        Hoclieu3RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        Hoclieu3RepositoryFolders.ĐăngNhậpSachMềmAppFolder _đăngnhậpsachmềm;

        /// <summary>
        /// Gets the singleton class instance representing the Hoclieu3Repository element repository.
        /// </summary>
        [RepositoryFolder("e6a46bcb-6618-4297-80ee-7a8cbf41fc2f")]
        public static Hoclieu3Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Hoclieu3Repository() 
            : base("Hoclieu3Repository", "/", null, 0, false, "e6a46bcb-6618-4297-80ee-7a8cbf41fc2f", ".\\RepositoryImages\\Hoclieu3Repositorye6a46bcb.rximgres")
        {
            _applicationundertest = new Hoclieu3RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _đăngnhậpsachmềm = new Hoclieu3RepositoryFolders.ĐăngNhậpSachMềmAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("e6a46bcb-6618-4297-80ee-7a8cbf41fc2f")]
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
        [RepositoryFolder("872af901-3959-464e-b4e6-a1d4f018715d")]
        public virtual Hoclieu3RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The ĐăngNhậpSachMềm folder.
        /// </summary>
        [RepositoryFolder("866ada0b-8129-469b-967a-249f2d41f4fb")]
        public virtual Hoclieu3RepositoryFolders.ĐăngNhậpSachMềmAppFolder ĐăngNhậpSachMềm
        {
            get { return _đăngnhậpsachmềm; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Hoclieu3RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("872af901-3959-464e-b4e6-a1d4f018715d")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            Hoclieu3RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder _httpshoclieusachmemvnquestionset;
            Hoclieu3RepositoryFolders.ContentBoundFolder _contentbound;
            RepoItemInfo _spantag11Info;
            RepoItemInfo _divtagthờigianbắtđầulớnhơnthờigiInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='hoclieu.sachmem.vn']", parentFolder, 30000, null, false, "872af901-3959-464e-b4e6-a1d4f018715d", "")
            {
                _httpshoclieusachmemvnquestionset = new Hoclieu3RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder(this);
                _contentbound = new Hoclieu3RepositoryFolders.ContentBoundFolder(this);
                _spantag11Info = new RepoItemInfo(this, "SpanTag11", "body//tag[@tagname='bs-calendar-layout']/div[2]/table/tbody/tr[2]/td[6]/span[@innertext='11']", 30000, null, "0f92147e-9a54-4a2a-a552-7f3ef9c56df5");
                _divtagthờigianbắtđầulớnhơnthờigiInfo = new RepoItemInfo(this, "DivTagThờiGianBắtĐầuLớnHơnThờiGi", ".//div[#'toast-container']/?/?/div[@innertext~'^\\ Thời\\ gian\\ bắt\\ đầu\\ lớn\\ hơ']", 30000, null, "2ee908c9-ab72-448b-b14d-b3f27fa6ddae");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("872af901-3959-464e-b4e6-a1d4f018715d")]
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
            [RepositoryItemInfo("872af901-3959-464e-b4e6-a1d4f018715d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SpanTag11 item.
            /// </summary>
            [RepositoryItem("0f92147e-9a54-4a2a-a552-7f3ef9c56df5")]
            public virtual Ranorex.SpanTag SpanTag11
            {
                get
                {
                    return _spantag11Info.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The SpanTag11 item info.
            /// </summary>
            [RepositoryItemInfo("0f92147e-9a54-4a2a-a552-7f3ef9c56df5")]
            public virtual RepoItemInfo SpanTag11Info
            {
                get
                {
                    return _spantag11Info;
                }
            }

            /// <summary>
            /// The DivTagThờiGianBắtĐầuLớnHơnThờiGi item.
            /// </summary>
            [RepositoryItem("2ee908c9-ab72-448b-b14d-b3f27fa6ddae")]
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
            [RepositoryItemInfo("2ee908c9-ab72-448b-b14d-b3f27fa6ddae")]
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
            [RepositoryFolder("a932ce20-c07b-403e-988f-faad30a670e5")]
            public virtual Hoclieu3RepositoryFolders.HttpsHoclieuSachmemVnQuestionSetFolder HttpsHoclieuSachmemVnQuestionSet
            {
                get { return _httpshoclieusachmemvnquestionset; }
            }

            /// <summary>
            /// The ContentBound folder.
            /// </summary>
            [RepositoryFolder("ffd7a6fe-aa8c-484b-9ae0-16ea96a56769")]
            public virtual Hoclieu3RepositoryFolders.ContentBoundFolder ContentBound
            {
                get { return _contentbound; }
            }
        }

        /// <summary>
        /// The HttpsHoclieuSachmemVnQuestionSetFolder folder.
        /// </summary>
        [RepositoryFolder("a932ce20-c07b-403e-988f-faad30a670e5")]
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
                    base("HttpsHoclieuSachmemVnQuestionSet", ".//div[#'createAssignmentModal']//form[@action='https://hoclieu.sachmem.vn/question_set/5a4b18b248150cd8b90656fe/5a4b18b248150cd8b9065701/preview']", parentFolder, 30000, null, false, "a932ce20-c07b-403e-988f-faad30a670e5", "")
            {
                _submitInfo = new RepoItemInfo(this, "Submit", "?/?/input[@type='submit']", 30000, null, "69b194d6-ef97-47e7-8b47-2aca4c8c5286");
                _textInfo = new RepoItemInfo(this, "Text", "div[1]/div[10]/?/?/input[@type='text']", 30000, null, "29228224-ce7f-4ff5-9092-61a603b134f5");
                _lớplớpInfo = new RepoItemInfo(this, "LớpLớp", "div[1]/div[3]/?/?/tag[@tagname='ng-dropdown-panel']/div/div[2]/?/?/span[@innertext='Lớp lớp']", 30000, null, "3a3a24da-e885-47f2-8dbc-e70d026b53df");
                _nginputInfo = new RepoItemInfo(this, "NgInput", "div[1]/div[3]/tag[@tagname='ng-select']/div/div/div[2]", 30000, null, "6c19fbe2-f991-4330-8477-89568e0aef6e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a932ce20-c07b-403e-988f-faad30a670e5")]
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
            [RepositoryItemInfo("a932ce20-c07b-403e-988f-faad30a670e5")]
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
            [RepositoryItem("69b194d6-ef97-47e7-8b47-2aca4c8c5286")]
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
            [RepositoryItemInfo("69b194d6-ef97-47e7-8b47-2aca4c8c5286")]
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
            [RepositoryItem("29228224-ce7f-4ff5-9092-61a603b134f5")]
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
            [RepositoryItemInfo("29228224-ce7f-4ff5-9092-61a603b134f5")]
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
            [RepositoryItem("3a3a24da-e885-47f2-8dbc-e70d026b53df")]
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
            [RepositoryItemInfo("3a3a24da-e885-47f2-8dbc-e70d026b53df")]
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
            [RepositoryItem("6c19fbe2-f991-4330-8477-89568e0aef6e")]
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
            [RepositoryItemInfo("6c19fbe2-f991-4330-8477-89568e0aef6e")]
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
        [RepositoryFolder("ffd7a6fe-aa8c-484b-9ae0-16ea96a56769")]
        public partial class ContentBoundFolder : RepoGenBaseFolder
        {
            RepoItemInfo _lớp4Info;
            RepoItemInfo _luyệntậptiếnganh4tập1Info;
            RepoItemInfo _đăngnhậpInfo;
            RepoItemInfo _javascriptvoid0Info;

            /// <summary>
            /// Creates a new ContentBound  folder.
            /// </summary>
            public ContentBoundFolder(RepoGenBaseFolder parentFolder) :
                    base("ContentBound", "body/tag[@tagname='app-root']/div[2]", parentFolder, 30000, null, false, "ffd7a6fe-aa8c-484b-9ae0-16ea96a56769", "")
            {
                _lớp4Info = new RepoItemInfo(this, "Lớp4", ".//ul/li[7]/div/div[1]/a[@innertext='Lớp 4']", 30000, null, "0c0fa53d-bd05-4e4f-b67a-5d5fc4d5062e");
                _luyệntậptiếnganh4tập1Info = new RepoItemInfo(this, "LuyệnTậpTiếngAnh4Tập1", ".//ul/li[7]/div/div[1]/a[@innertext~'^Luyện\\ tập\\ Tiếng\\ Anh\\ 4\\ Tập']", 30000, null, "7ff3a820-17d5-4f53-a3bc-ef338941998e");
                _đăngnhậpInfo = new RepoItemInfo(this, "ĐăngNhập", "div//div[@innertext~'^\\ \\ Để\\ sử\\ dụng\\ bạn\\ cần\\ \\ ho']/a[@innertext='Đăng nhập']", 30000, null, "6f01153e-04a7-438d-972f-c003036e54ff");
                _javascriptvoid0Info = new RepoItemInfo(this, "JavascriptVoid0", "div//tag[@tagname='question']/div/div[2]/div/?/?/tag[@tagname='app-preview-list-question']/div/div[1]/div[1]/div[2]/a[@href='javascript:void(0)']", 30000, null, "d9b822b8-a46e-4479-a138-a47a34ef62b3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ffd7a6fe-aa8c-484b-9ae0-16ea96a56769")]
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
            [RepositoryItemInfo("ffd7a6fe-aa8c-484b-9ae0-16ea96a56769")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Lớp4 item.
            /// </summary>
            [RepositoryItem("0c0fa53d-bd05-4e4f-b67a-5d5fc4d5062e")]
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
            [RepositoryItemInfo("0c0fa53d-bd05-4e4f-b67a-5d5fc4d5062e")]
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
            [RepositoryItem("7ff3a820-17d5-4f53-a3bc-ef338941998e")]
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
            [RepositoryItemInfo("7ff3a820-17d5-4f53-a3bc-ef338941998e")]
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
            [RepositoryItem("6f01153e-04a7-438d-972f-c003036e54ff")]
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
            [RepositoryItemInfo("6f01153e-04a7-438d-972f-c003036e54ff")]
            public virtual RepoItemInfo ĐăngNhậpInfo
            {
                get
                {
                    return _đăngnhậpInfo;
                }
            }

            /// <summary>
            /// The JavascriptVoid0 item.
            /// </summary>
            [RepositoryItem("d9b822b8-a46e-4479-a138-a47a34ef62b3")]
            public virtual Ranorex.ATag JavascriptVoid0
            {
                get
                {
                    return _javascriptvoid0Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The JavascriptVoid0 item info.
            /// </summary>
            [RepositoryItemInfo("d9b822b8-a46e-4479-a138-a47a34ef62b3")]
            public virtual RepoItemInfo JavascriptVoid0Info
            {
                get
                {
                    return _javascriptvoid0Info;
                }
            }
        }

        /// <summary>
        /// The ĐăngNhậpSachMềmAppFolder folder.
        /// </summary>
        [RepositoryFolder("866ada0b-8129-469b-967a-249f2d41f4fb")]
        public partial class ĐăngNhậpSachMềmAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _commitInfo;

            /// <summary>
            /// Creates a new ĐăngNhậpSachMềm  folder.
            /// </summary>
            public ĐăngNhậpSachMềmAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ĐăngNhậpSachMềm", "/dom[@domain='accounts.sachmem.vn']", parentFolder, 30000, null, false, "866ada0b-8129-469b-967a-249f2d41f4fb", "")
            {
                _commitInfo = new RepoItemInfo(this, "Commit", ".//form[#'new_user']/?/?/input[@name='commit']", 30000, null, "27546de2-af3d-4053-bd70-21f75b4666a3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("866ada0b-8129-469b-967a-249f2d41f4fb")]
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
            [RepositoryItemInfo("866ada0b-8129-469b-967a-249f2d41f4fb")]
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
            [RepositoryItem("27546de2-af3d-4053-bd70-21f75b4666a3")]
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
            [RepositoryItemInfo("27546de2-af3d-4053-bd70-21f75b4666a3")]
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