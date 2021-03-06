﻿// 2010 Felice Pollano
// felice@felicepollano.com
// www.felicepollano.com
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using NHibernate.Tool.WorkBench.Core.WireAttributes;
using NHibernate.Tool.WorkBench.Core;

namespace NHibernate.Tool.WorkBench.Mapping
{
    [PresenterView]
    partial class MappingDocument : SupportEditorCommandContent
    {
        public MappingDocument(MainForm form)
        {
            InitializeComponent();
            ShowHint = DockState.Document;
            Show(form.DockPanel);
            SetEditor(GetEditor());
        }

        protected override string GetFilterString()
        {
            return ApplicationEnvironment.Instance.MappingFilterString;
        }

        public override ICSharpCode.TextEditor.TextEditorControl GetEditor()
        {
            return xmlEditorControl1;
        }
    }
}
