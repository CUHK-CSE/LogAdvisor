##LogAdvisor

This repository maintains the source code for our project "Learning to Log", which aims to automatically learn the common logging practice from existing code repositories. The source code is used to extract all the data instances (including the extracted features and logging labels).

Read more information: [[Paper](http://appsrv.cse.cuhk.edu.hk/~jmzhu/pub/jmzhu_icse2015.pdf)][[Project page](http://tiic.github.io/LogAdvisor)]


##Citation

If you use any benchmark in published research, please kindly \*cite* the following paper. Thanks!

- Jieming Zhu, Pinjia He, Qiang Fu, Hongyu Zhang, Michael R. Lyu, and Dongmei Zhang, "Learning to Log: Helping Developers Make Informed Logging Decisions," in Proc. of ACM/IEEE ICSE, 2015.


##Dependencies

- Visual Studio 2012 or later
- Roslyn: https://roslyn.codeplex.com


##Code Archive

```
data/
  - MonoDevelop/        - the extracted raw features and their arff files
  - SharpDevelop/       - the extracted raw features and their arff files
document/               - the help documents for Roslyn
scripts/                - the scripts to execute the program for raw feature 
                          extraction 
src/                    - the source code for feature extraction based on 
                          Roslyn and C#
user_study/             - the materials for user study
```
	  

##Issues

In case of questions or problems, please do not hesitate to report to our 
issue page (https://github.com/TIIC/LogAdvisor/issues). We will help ASAP. 
In addition, we will appreciate any contribution to refine and optimize this 
package.


##Copyright &copy;

Permission is granted for anyone to copy, use, modify, or distribute this program and accompanying programs and documents for any purpose, provided this copyright notice is retained and prominently displayed, along with a 
note saying that the original programs are available from our web page (http://tiic.github.io/LogAdvisor). The program is provided as-is, and there are no guarantees that it fits your purposes or that it is bug-free. All use of these programs is entirely at the user's own risk.	  
