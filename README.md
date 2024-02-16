# Intro

The goal is to review code written by a fictional intern. Let's pretend that the intern without prior experience was supposed to work on a task with a senior engineer, however our engineer got sick with Dragon Pox. The intern prepared some code in [branch `task`](https://github.com/prokopst/BackendTaskPilot/tree/task) within a couple of days on his own and thinks it satisfies the requirements described bellow.

Do a formal code review and suggest improvements (if any) by opening a completely new PR:

1. [Fork this repository](https://github.com/prokopst/BackendTaskPilot/fork).
    * Untick "Copy the `main` branch only" since the task is in [`task` branch](https://github.com/prokopst/BackendTaskPilot/tree/task).
2. Create a PR from a `task` branch from your own fork.
3. Comment on your PR.
    * See an existing [PR](https://github.com/prokopst/BackendTaskPilot/pull/1) if you are unfamiliar with GitHub PRs.
    * Don't forget to submit reviews, otherwise we won't see your comments.
    * See [official documentation](https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/reviewing-changes-in-pull-requests/reviewing-proposed-changes-in-a-pull-request#starting-a-review) for reviewing changes.

The goal is to make sure that the service is production ready and that the intern will learn from their mistakes. Each topic you raise should be a separate comment, either to a specific line or a general PR comment.

If there is a problem with a method and you recommend to do things differently, feel free to still suggest improvements on the code within the methods itself, so the intern can learn. For example if you think that a variable name deserves improvement in a method which you suggest to remove completely, it's still worth to suggest an improvement on the variable name anyway. This way the fictional intern learns as much as possible.

## The original requirements

> [!IMPORTANT]  
> These are the original requirements which were supposed to be satisfied by a fictional intern. Your task is not to create such service, but to review the intern's attempt.

As part of the property management system (PMS) we let customers define their own exchange rates, however couple of customers expressed interest in using the official exchange rates.

As part of the project, We need an HTTP service which accepts a source currency and target currencies and returns the latest rates. A source currency may be optional for now, within the first iteration we plan to support only CZK as a source currency. CNB provides structured data over some publicly accessible endpoint, so it's highly recommended to go with that.  

A list of required currencies for the first iteration: USD, EUR, JPY, SAR, KES.

The service is going to be used by the rest of the PMS to see the latest exchange rate. The pilot will target only hotels with CZK. The service should be production ready and scalable to avoid any reputation loss.
