using System;

namespace TagMaker {
  public class TagMaker {
    public string Name {get; set;}
    public string Organization {get; set;}
    public void PrintTag() {
       
      Console.WriteLine(String.Format("##################################################################################\n" +
                                      "###                             ANNUAL CONFERENCE                              ###\n" +
                                      "##################################################################################\n" +
                                      "### Name: {0, -69}###\n" +
                                      "###                                                                            ###\n" +
                                      "##################################################################################\n" +
                                      "### ORGANIZATION: {1, -61}###\n" +                  
                                      "###                                                                            ###\n" +
                                      "###                                                                            ###\n" +
                                      "##################################################################################\n", 
                                      Name, Organization));
    }                    
    public void ClearSettings() {
      Name = null;
      Organization = null;
    }
    public static void PrintBlankTag() {
      //making sure printing a blank tag doesn't interfere with the settings
      Console.WriteLine("##################################################################################\n" +
                        "###                             ANNUAL CONFERENCE                              ###\n" +
                        "##################################################################################\n" +
                        "### Name:                                                                      ###\n" +
                        "###                                                                            ###\n" +
                        "##################################################################################\n" +
                        "### ORGANIZATION:                                                              ###\n" +
                        "###                                                                            ###\n" +
                        "###                                                                            ###\n" +
                        "##################################################################################\n");
    }
  }
}