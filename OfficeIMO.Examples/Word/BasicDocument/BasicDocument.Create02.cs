﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeIMO.Word;

namespace OfficeIMO.Examples.Word {
    internal static partial class BasicDocument {
        public static void Example_BasicWordWithBreaks(string folderPath, bool openWord) {
            Console.WriteLine("[*] Creating standard document with paragraph & breaks");
            string filePath = System.IO.Path.Combine(folderPath, "BasicDocumentWithParagraphsAndBreaks.docx");
            using (WordDocument document = WordDocument.Create(filePath)) {
                var paragraph1 = document.AddParagraph("Adding paragraph1 with some text and pressing ENTER");


                var paragraph2 = document.AddParagraph("Adding paragraph2 with some text and pressing SHIFT+ENTER");
                paragraph2.AddBreak();
                paragraph2.AddText("Continue1");
                paragraph2.AddBreak();
                paragraph2.AddText("Continue2");

                var paragraph3 = document.AddParagraph("Adding paragraph3 with some text and pressing ENTER");

                var paragraph4 = document.AddParagraph("Adding paragraph4 with some text and pressing SHIFT+ENTER");
                paragraph4.AddBreak();

                document.Save(openWord);
            }
        }
    }
}
