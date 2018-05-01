using System.Diagnostics;
using UnityEditor;

public class BuildAndPushToItch
{
    [MenuItem("itch.io/Build and push to itch.io")]
    public static void BuildAndPush()
    {
        var webPath = "E:/Temp/web"; // Replace with your web output folder
        var androidPath = "E:/Temp/android/MyApkFile.apk"; // Replace with your android output file
        var buildLevels = new string[] { "Assets/Scenes/MyScene.unity" }; // Replace with your own scenes

        BuildPipeline.BuildPlayer(buildLevels, webPath, BuildTarget.WebGL, BuildOptions.None);

        PushToItch("web", "HTML");

        BuildPipeline.BuildPlayer(buildLevels, androidPath, BuildTarget.Android, BuildOptions.None);

        PushToItch("android", "android");
    }

   ublic static void PushToItch(string folderName, string channel)
    {
        // Prior running this, you must run 'butler login' at least once, so that the credentials are available.
        var proc = new Process();
        proc.StartInfo.FileName = "butler";
        proc.StartInfo.WorkingDirectory = "E:/Temp";
        proc.StartInfo.Arguments = "push " + folderName + " username/projectname:" + channel; // Replace this with your username/projectname
        var pr = proc.Start();
    }
}
