# Create a new issue
In order to create a new issue the following markdown template (consulted from [GitHub Docs](https://docs.github.com/en/communities/using-templates-to-encourage-useful-issues-and-pull-requests/syntax-for-issue-forms)) should be used. You can also get the template file here in [ISSUE_TEMPLATE](ISSUE_TEMPLATE.md)

```markdown
---
name: 🐞 Bug
about: File a bug/issue
labels: Bug, Needs Triage
assignees: '@'

---

<!--
Note: Please search to see if an issue already exists for the bug you encountered.
-->

### Current Behavior:
<!-- A concise description of what you're experiencing. -->

### Expected Behavior:
<!-- A concise description of what you expected to happen. -->

### Steps To Reproduce:
<!--
Example: steps to reproduce the behavior:
1. In this environment...
2. With this config...
3. Run '...'
4. See error...
-->

### Environment:
<!--
Example:
- OS: Ubuntu 20.04
- Node: 13.14.0
- npm: 7.6.3
-->

### Anything else:
<!--
Links? References? Anything that will give us more context about the issue that you are encountering!
-->
```
This template can be modified (if some fields aren't neccesary), but the overall structure should be kept in order to retrieve most of the data to resolve the issue.