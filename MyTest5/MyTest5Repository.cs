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

namespace MyTest5
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest5Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("04f203cf-482d-4add-8c13-3681543c3fad")]
    public partial class MyTest5Repository : RepoGenBaseFolder
    {
        static MyTest5Repository instance = new MyTest5Repository();
        MyTest5RepositoryFolders.ShellEnvAppFolder _shellenv;
        MyTest5RepositoryFolders.RxSupportSalesforceAppFolder _rxsupportsalesforce;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest5Repository element repository.
        /// </summary>
        [RepositoryFolder("04f203cf-482d-4add-8c13-3681543c3fad")]
        public static MyTest5Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest5Repository() 
            : base("MyTest5Repository", "/", null, 0, false, "04f203cf-482d-4add-8c13-3681543c3fad", ".\\RepositoryImages\\MyTest5Repository04f203cf.rximgres")
        {
            _shellenv = new MyTest5RepositoryFolders.ShellEnvAppFolder(this);
            _rxsupportsalesforce = new MyTest5RepositoryFolders.RxSupportSalesforceAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("04f203cf-482d-4add-8c13-3681543c3fad")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ShellEnv folder.
        /// </summary>
        [RepositoryFolder("6de9f9a0-8f81-45bf-94a9-223c65223ad3")]
        public virtual MyTest5RepositoryFolders.ShellEnvAppFolder ShellEnv
        {
            get { return _shellenv; }
        }

        /// <summary>
        /// The RxSupportSalesforce folder.
        /// </summary>
        [RepositoryFolder("05d48cbd-1d1a-4de5-8e27-e3dec455fcc0")]
        public virtual MyTest5RepositoryFolders.RxSupportSalesforceAppFolder RxSupportSalesforce
        {
            get { return _rxsupportsalesforce; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest5RepositoryFolders
    {
        /// <summary>
        /// The ShellEnvAppFolder folder.
        /// </summary>
        [RepositoryFolder("6de9f9a0-8f81-45bf-94a9-223c65223ad3")]
        public partial class ShellEnvAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _testtemplateInfo;

            /// <summary>
            /// Creates a new ShellEnv  folder.
            /// </summary>
            public ShellEnvAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ShellEnv", "/form[@controlname='ShellEnv']", parentFolder, 30000, null, true, "6de9f9a0-8f81-45bf-94a9-223c65223ad3", "")
            {
                _testtemplateInfo = new RepoItemInfo(this, "TestTemplate", "container[@controlname='_pnlLeft']/container[@controlname='_pnlDetails']/container[@controlname='_myTabControl']/element/element/container/container/container/tabpagelist/tabpage[@title='Templates']/container[@automationid='TemplatesViewTab']/container/table/container/element/element/container/container[2]/row[@index='8']/container/container/element/container/cell[@text='TestTemplate']", "", 30000, null, "89134210-5c80-4f6e-948c-b993c5ef08e5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6de9f9a0-8f81-45bf-94a9-223c65223ad3")]
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
            [RepositoryItemInfo("6de9f9a0-8f81-45bf-94a9-223c65223ad3")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TestTemplate item.
            /// </summary>
            [RepositoryItem("89134210-5c80-4f6e-948c-b993c5ef08e5")]
            public virtual Ranorex.Cell TestTemplate
            {
                get
                {
                    return _testtemplateInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The TestTemplate item info.
            /// </summary>
            [RepositoryItemInfo("89134210-5c80-4f6e-948c-b993c5ef08e5")]
            public virtual RepoItemInfo TestTemplateInfo
            {
                get
                {
                    return _testtemplateInfo;
                }
            }
        }

        /// <summary>
        /// The RxSupportSalesforceAppFolder folder.
        /// </summary>
        [RepositoryFolder("05d48cbd-1d1a-4de5-8e27-e3dec455fcc0")]
        public partial class RxSupportSalesforceAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _somedivtagInfo;

            /// <summary>
            /// Creates a new RxSupportSalesforce  folder.
            /// </summary>
            public RxSupportSalesforceAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxSupportSalesforce", "/dom[@domain='na158.lightning.force.com']", parentFolder, 30000, null, false, "05d48cbd-1d1a-4de5-8e27-e3dec455fcc0", "")
            {
                _somedivtagInfo = new RepoItemInfo(this, "SomeDivTag", "body/div[4]/div[1]/section/div[1]/div/div[2]/div[2]/section[7]/div/div/section/div/div[2]/div/div/div/div[2]/iframe//div[#'main']/div/div[1]/div/div/div/div[1]/div[2]/div[2]/div[3]/div/article/div[1]/div/div[1]/div/div[1]", "", 30000, null, "71586817-4c88-4852-8fc2-7b6ae5bfe21e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("05d48cbd-1d1a-4de5-8e27-e3dec455fcc0")]
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
            [RepositoryItemInfo("05d48cbd-1d1a-4de5-8e27-e3dec455fcc0")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SomeDivTag item.
            /// </summary>
            [RepositoryItem("71586817-4c88-4852-8fc2-7b6ae5bfe21e")]
            public virtual Ranorex.DivTag SomeDivTag
            {
                get
                {
                    return _somedivtagInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The SomeDivTag item info.
            /// </summary>
            [RepositoryItemInfo("71586817-4c88-4852-8fc2-7b6ae5bfe21e")]
            public virtual RepoItemInfo SomeDivTagInfo
            {
                get
                {
                    return _somedivtagInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
