# C\# 语法教程配套代码

这个仓库用来存储一些我录制的 C\# 编程视频里用到的程序代码等内容。

## 代码使用方式

请打开里面的 `src` 文件夹，里面可以找到对应的每一个视频分 p 的对应代码。命名均为 `Tutorial数字`，其中的数字部分就是**分 p 的对应总序列编号**。比如你看到的 `Tutorial040` 文件夹就对应了第 40 个分 p（即视频名为“032★ - `switch` 语句的细节”）的视频内容，因为可以在[这个文档](Video-List.md)里找到对应编号，这个视频的总序列号是 40。

请注意代码的架构。整个项目是用一个解决方案存储的，而整个解决方案里包含了众多项目，每一个分 p 均按一个单独的项目存储。其中的 `csproj` 文件则是每一个项目的配置文件，而整个 `sln` 文件才是解决方案的文件。你需要打开的是 `sln` 的文件。

另外，`Directory.Build.props` 文件里面设置和配置了所有项目都相同的设置项。这些设置项会自动拷贝到每一个子项目里，因此这个文件尽量不要动，因为改变这个单独的文件会影响到整个解决方案下的所有项目的配置内容。

## 网站

视频教学在哔哩哔哩上，请查看[C\# 语法教程（视频版）](https://www.bilibili.com/video/BV1wQ4y1i7nd)链接。

视频的文字版教学也在哔哩哔哩上，请查看[C\# 语法教程（专栏版）](https://www.bilibili.com/read/readlist/rl392350)链接。另外文字版我还会找机会拷贝放到这个仓库下。请打开 GitHub Pages 查看该内容，点击[这里](https://sunnieshine.github.io/CSharpLearning/)进去。

视频分 p 对应表请参阅[这个文档](Video-List.md)的内容。

## 开源协议

[MIT](LICENSE)

## 作者

[SunnieShine](https://space.bilibili.com/23736703)