using System;

namespace TagMaker {
    public class TagMakerTest {
        public static void Main (string[] args) {
            TagMaker testTagMaker = new TagMaker();
            testTagMaker.PrintTag();

            testTagMaker.Name = "Ivy";
            testTagMaker.Organization = "Berkeley City College";
            testTagMaker.PrintTag();

            testTagMaker.PrintBlankTag();
            testTagMaker.PrintTag();

            testTagMaker.ClearSettings();
            testTagMaker.PrintTag(); 
        }
    }
}