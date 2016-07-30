using System;
using MonoDevelop.Ide;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide.Gui;
using Mono.TextEditor;

namespace XamarinStudio.InsertDate {
	public class InsertDateHandler: CommandHandler {
		public InsertDateHandler() {
		}

		protected override void Run() {
			var doc = IdeApp.Workbench.ActiveDocument;
			var textEditorData = doc.GetContent<ITextEditorDataProvider>().GetTextEditorData();
			var date = DateTime.Now.ToString();
			textEditorData.InsertAtCaret(date);
		}

		protected override void Update(CommandInfo info) {
			var doc = IdeApp.Workbench.ActiveDocument;
			info.Enabled = doc != null && doc.GetContent<ITextEditorDataProvider>() != null;
		}
	}
}

