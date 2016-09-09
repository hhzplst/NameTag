using System;

namespace TagMaker {
    public class TagMakerTest {
        public static void Main (string[] args) {
            TagMaker testTagMaker = new TagMaker();
            Console.WriteLine("Printing the Intial Tag...");
            testTagMaker.PrintTag();
            
            Console.WriteLine("Printing the Name Tag for Ivy from BCC...");
            testTagMaker.Name = "Ivy Chang";
            testTagMaker.Organization = "Berkeley City College";
            testTagMaker.PrintTag();

            Console.WriteLine("Printing an Empty Tag...");
            testTagMaker.PrintBlankTag();

            Console.WriteLine("Printing the Name Tag for Austen from Cal...");
            testTagMaker.Name = "Austen-Lane Roberts";
            testTagMaker.Organization = "Cal";
            testTagMaker.PrintTag();

            Console.WriteLine("Clearing the Settings...");
            testTagMaker.ClearSettings(); 
        }
    }
}

/*********************************************TEST OUTPUT************************************************

➜  NameTag git:(master) ✗ dotnet run
Project NameTag (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling NameTag for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.6124137
 

Printing the Intial Tag...
##################################################################################
###                             ANNUAL CONFERENCE                              ###
##################################################################################
### Name:                                                                      ###
###                                                                            ###
##################################################################################
### ORGANIZATION:                                                              ###
###                                                                            ###
###                                                                            ###
##################################################################################

Printing the Name Tag for Ivy from BCC...
##################################################################################
###                             ANNUAL CONFERENCE                              ###
##################################################################################
### Name: Ivy Chang                                                            ###
###                                                                            ###
##################################################################################
### ORGANIZATION: Berkeley City College                                        ###
###                                                                            ###
###                                                                            ###
##################################################################################

Printing an Empty Tag...
##################################################################################
###                             ANNUAL CONFERENCE                              ###
##################################################################################
### Name:                                                                      ###
###                                                                            ###
##################################################################################
### ORGANIZATION:                                                              ###
###                                                                            ###
###                                                                            ###
##################################################################################

Printing the Name Tag for Austen from Cal...
##################################################################################
###                             ANNUAL CONFERENCE                              ###
##################################################################################
### Name: Austen-Lane Roberts                                                  ###
###                                                                            ###
##################################################################################
### ORGANIZATION: Cal                                                          ###
###                                                                            ###
###                                                                            ###
##################################################################################

Clearing the Settings...


*******************************************END TEST OUTPUT**********************************************/