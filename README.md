# GitHub Pages Deploy Monitor

A [Windows Forms](https://github.com/dotnet/winforms) application, built using [VS Community 2022](https://visualstudio.microsoft.com/vs/community/) for Windows 10+, and packaged with [Advanced Installer](https://www.advancedinstaller.com/). The purpose of this app is to notify the user through a notification when their [Github Page](https://pages.github.com/)'s build and deployment checks have passed since the last push, indicating it has been updated server-side. 
Not affiliated with Github.

## Installation

1. Download x64/ARM64_GithubPagesDeployMonitor-v*.\*.*_Setup.msi from https://github.com/redbackspider69/GitHubPagesDeployMonitor/releases/latest, depending on your system architecture.
2. Run the installation file.
3. You can now find a shortcut for the application in your start menu.

## Usage

### Choosing repository to monitor
Enter the directory of the Github Page repository that you want to monitor in the first box, in the format of `owner/repo`.

### API Key
- Not using a personal API key will only allow 60 requests per hour, so a higher check interval or API key is recommended. You will not be able to monitor a private repository without an API key.
- To generate and use an API key with the correct scopes, you may follow these instructions:
1. Go to https://github.com/settings/personal-access-tokens/new?type=fine-grained.
2. Choose any name, such as `Github Pages Deploy Monitor`.
3. If you are planning to monitor a public repository, choose `Public repositories` under `Repository access`.
4. If you are planning to monitor a private repo, choose `Only select repositories` under `Repository access`. Then select `Read-only` for `Contents` in `Repository permissions`.
5. Generate the API key and paste it in the settings.

### Ignoring commits by certain authors
If you wish to not monitor commits made by a certain author, add a text that is contained in the authors name. For example, if you wish to ignore commits made by [Dependabot](https://github.com/dependabot), you may add `bot` to the list.

### Adjusting check interval
The check interval sets how many milliseconds pass between checking for a new push and how many milliseconds pass between waiting for checks to complete. A higher check interval is recommended if not using an API key, as only 60 requests are allowed per hour. The default value is 3000 milliseconds.

## How the UI and notifications look like

<table>
  <tr>
    <td align="center" width=1000>
      <img src="/assets/UI.png"/> 
    </td>
    <td align="center" width=1000>
      <img src="/assets/PushDetected.png"/> 
      <img src="/assets/PageUpdated.png"/>
    </td>
  </tr>
</table>

## To-do list
- wait for suggestions

### About me

This is my first Windows application, my first time using Windows Forms, and my first time using Visual Studio. I've leaked my own API keys while testing it a few times, so I really am an amateur. (Don't worry, I've disabled them now) If I have structured something wrong, please correct me, as I was never taught how to share Visual Studio projects on Github, and just created a new repo in my project's files folder.
