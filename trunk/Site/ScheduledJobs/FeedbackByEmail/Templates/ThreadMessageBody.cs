﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 11.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ScheduledJobs.FeedbackByEmail.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public partial class ThreadMessageBody : ThreadMessageBodyBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<!DOCTYPE html>
<html style=""height:100%;min-height:100%;"">
<body marginheight=""0"" topmargin=""0"" marginwidth=""0"" leftmargin=""0"" style=""height:100%;min-height:100%;color:#474747;font-family:arial;"" >
<table width=""100%"" height=""100%"" cellpadding=""0"" cellspacing=""0"" class=""feedback-mail__wrapper"" style=""width:100%;height:100%;background-color:#e3e8ed;background-image:none;background-repeat:repeat;background-position:top left;background-attachment:scroll;"" ><tr><td valign=""top"" style=""color:#474747;font-family:arial;"">
<table width=""640"" height=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"" class=""feedback-mail__content-block"" style=""width:640px;height:100%;background-color:#fff;background-image:none;background-repeat:repeat;background-position:top left;background-attachment:scroll;"" ><tr><td width=""20""></td><td valign=""top"" style=""color:#474747;font-family:arial;"">
	<h3 style=""font-size:23px;color:#2d4780;"">");
            
            #line 11 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Title));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t<table width=\"600\" cellspacing=\"0\" cellpadding=\"5\" class=\"feedback-mail__" +
                    "conversation-grid\" style=\"font-size:13px;width:600px;border-collapse:collapse;\" " +
                    ">\r\n\t\t");
            
            #line 13 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
 foreach (var message in Messages) { 
            
            #line default
            #line hidden
            this.Write(@"		<tr>
			<td class=""feedback-mail__col-author"" style=""font-family:arial;width:120px;vertical-align:top;background-color:#b2bcce;background-image:none;background-repeat:repeat;background-position:top left;background-attachment:scroll;color:#fff;border-width:1px;border-style:solid;border-color:#fff;"" >
				<font class=""feedback-mail__author"" style=""font-weight:bold;color: #ffffff;"">");
            
            #line 16 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(message.IsOperator ? "Оператор" : "Клиент"));
            
            #line default
            #line hidden
            this.Write("</font><br>\r\n\t\t\t\t<font class=\"feedback-mail__time\" style=\"font-size:10px; color: " +
                    "#ffffff;\">");
            
            #line 17 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(message.Time.ToString("dd.MM.yyyy HH:mm:ss")));
            
            #line default
            #line hidden
            this.Write(@"</font>
			</td>
			<td class=""feedback-mail__col-message"" valign=""top"" style=""color:#474747;font-family:arial;background-color:#e3e8ed;background-image:none;background-repeat:repeat;background-position:top left;background-attachment:scroll;border-width:1px;border-style:solid;border-color:#fff;"" >
<pre wrap="""" class=""feedback-mail__message"" style=""white-space:pre-wrap;color: #474747;"">");
            
            #line 20 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(message.Text));
            
            #line default
            #line hidden
            this.Write("</pre>\r\n\t\t\t\t");
            
            #line 21 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
 if (message.Attachments.Length > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<ul class=\"feedback-mail__attach-list\" style=\"list-style-type:disc;margin-top" +
                    ":20px;\">\r\n\t\t\t\t\t");
            
            #line 23 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
 foreach (var attach in message.Attachments) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<li style=\"color: #474747;\"><a href=\"");
            
            #line 24 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attach.Url));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 24 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(attach.Title));
            
            #line default
            #line hidden
            this.Write("</a></li>\r\n\t\t\t\t\t");
            
            #line 25 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</ul>\r\n\t\t\t\t");
            
            #line 27 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t</td>\r\n\t\t</tr>\r\n\t\t");
            
            #line 30 "D:\RSProjects\VTB24\trunk\Site\ScheduledJobs\FeedbackByEmail\Templates\ThreadMessageBody.tt"
 } 
            
            #line default
            #line hidden
            this.Write(@"	</table>

	<p style=""margin-top:20px;margin-bottom:20px;margin-right:5px;margin-left:5px;font-size:11px;color:#aaaaaa;"" >
		<b>Ответьте</b> на данное письмо для добавления сообщения в переписку. <b>Cотрите</b> лишнее содержимое из письма перед написанием ответа!
	</p>
<td width=""20""></td></td></tr></table>
</td></tr></table>
</body>
</html>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "11.0.0.0")]
    public class ThreadMessageBodyBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
