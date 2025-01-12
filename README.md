<p align="center"> <a href="https://github.com/logpai"> <img src="https://github.com/logpai/logpai.github.io/blob/master/img/logpai_logo.jpg" width="425"></a></p>

# LogAdvisor

This repository maintains the source code for our project "Learning to Log", which aims to automatically learn the common logging practice from existing code repositories. The source code is used to extract all the data instances (including the extracted features and logging labels) in our work.

Read more information from our paper:
- Jieming Zhu, Pinjia He, Qiang Fu, Hongyu Zhang, Michael R. Lyu, and Dongmei Zhang. [Learning to Log: Helping Developers Make Informed Logging Decisions](https://jiemingzhu.github.io/pub/jmzhu_icse2015.pdf), *International Conference on Software Engineering (ICSE)*, 2015.
- Qiang Fu, Jieming Zhu, Wenlu Hu, Jian-Guang Lou, Rui Ding, Qingwei Lin, Dongmei Zhang, and Tao Xie. [Where Do Developers Log? An Empirical Study on Logging Practices in Industry](https://jiemingzhu.github.io/pub/qfu_icse2014.pdf), *International Conference on Software Engineering (ICSE)*, 2014.


## Dependencies

- Visual Studio 2012 or later
- Roslyn: https://github.com/dotnet/roslyn


## Code Archive

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
	  

## Issues

In case of questions or problems, please do not hesitate to report to [the 
issue page](https://github.com/logpai/LogAdvisor/issues). We will respond ASAP. 
In addition, we appreciate any contribution to optimize and improve this 
package.



Copyright &copy; 2017, The [LogPAI](https://github.com/logpai) Team  
