using System;

namespace TagMaker {
  public class TagMaker {
    public string Name {get; set;}
    public string Organization {get; set;}
    public void PrintTag() {
      Console.WriteLine("##################################################################################");
      Console.WriteLine("###                             ANNUAL CONFERENCE                              ###");
      Console.WriteLine("##################################################################################");
      Console.WriteLine("### NAME:  {0}                                                                 ###", Name);
      Console.WriteLine("###                                                                            ###");
      Console.WriteLine("##################################################################################");
      Console.WriteLine("### ORGANIZATION:  {0}                                                         ###", Organization);
      Console.WriteLine("###                                                                            ###");
      Console.WriteLine("##################################################################################");
    }
    public void ClearSettings() {
      Name = null;
      Organization = null;
    }
    public void PrintBlankTag() {
      ClearSettings();
      PrintTag();
    }
  }
}