using System;

namespace TagMaker {
  public class TagMaker {
    public string Name {get; set;}
    public string Organization {get; set;}
    public void PrintTag() {
       
      Console.WriteLine("##################################################################################\n" +
                        "###                             ANNUAL CONFERENCE                              ###\n" +
                        "##################################################################################");
      Console.WriteLine(String.Format("### Name: {0, -69}###", Name));
      Console.WriteLine("###                                                                            ###\n" +
                        "##################################################################################");
      Console.WriteLine(String.Format("### ORGANIZATION: {0, -61}###", Organization));                  
      Console.WriteLine("###                                                                            ###\n" +
                        "###                                                                            ###\n" +
                        "##################################################################################\n");
    }                    
    public void ClearSettings() {
      Name = null;
      Organization = null;
    }
    public static void PrintBlankTag() {
      
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