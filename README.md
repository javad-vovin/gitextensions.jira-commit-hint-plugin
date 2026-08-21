# Jira Commit Hint Plugin for Git Extensions

> **Note:** This repository is a fork of the original [ierof/gitextensions.jiracommithintplugin](https://github.com/ierof/gitextensions.jiracommithintplugin).

Provides hints and auto-complete templates for Atlassian Jira issues directly within the Git Extensions commit dialog. For example, you can automatically generate and select `[Key] Summary` commit messages for all your active tasks.

---

## 🚀 Key Improvements in this Fork

- **Git Extensions 7.x Support**: Migrated to **.NET 10 (`net10.0-windows`)** and updated for the latest Git Extensions Extensibility APIs.
- **Enhanced Authentication Support**:
  - **Jira Cloud**: Authenticate with email address and Atlassian API Token.
  - **Jira Server / Data Center (Self-Hosted)**: Authenticate with username and password, or use **Personal Access Tokens (PAT)** via Bearer authorization.
- **Fixed Assembly Loading**: Self-contained dependency resolution preventing `ReflectionTypeLoadException` in the Git Extensions plugin host.

---

## 📦 Installation

### Option 1: Via Git Extensions Plugin Manager (Recommended)
1. Open Git Extensions.
2. Go to **Plugins** $\rightarrow$ **Plugin Manager...**
3. Search for **Jira Commit Hint** and click **Install**.
4. Restart Git Extensions.

### Option 2: Manual Installation
1. Download the latest release from the [Releases](https://github.com/ierof/gitextensions.jiracommithintplugin/releases) page.
2. Extract the contents into your Git Extensions `UserPlugins` folder:
   ```
   %LOCALAPPDATA%\GitExtensions\UserPlugins\GitExtensions.JiraCommitHintPlugin\
   ```
3. Restart Git Extensions.

---

## ⚙️ Configuration

Open Git Extensions and go to **Tools** $\rightarrow$ **Settings** $\rightarrow$ **Plugins** $\rightarrow$ **Jira Commit Hint**:

1. **Jira hint plugin enabled**: Check to enable the plugin.
2. **Jira URL**: The full URL to your Jira instance (e.g., `https://your-domain.atlassian.net` or `https://jira.yourcompany.com`).
3. **Credentials**:
   - **Jira Cloud**: Enter your **Atlassian Account Email** in the *User Name* field and your **Atlassian API Token** in the *Password* field ([Generate an API token](https://id.atlassian.com/manage-profile/security/api-tokens)).
   - **Self-Hosted Jira (Password)**: Enter your standard Jira username and password.
   - **Self-Hosted Jira (PAT)**: Leave the *User Name* field **empty** and paste your **Personal Access Token** in the *Password* field.
4. **JQL Query**: Customize the query used to fetch your active tasks (default: `assignee = currentUser() and resolution is EMPTY ORDER BY updatedDate DESC`).
5. **Message Template**: Format of the generated commit message (default: `{Key} {Summary}`).
6. **Preview**: Click the **Preview** button to verify connectivity and test your query.

---

## 📄 License

This project is licensed under the [Apache-2.0 License](LICENSE).
