Reference from Link : https://www.c-sharpcorner.com/article/understand-antiforgeri-token-in-asp-net-mvc/

We need to add @Html.AntiForgeryToken() in view which will generate a hidden field in view.
[ValidateAntiForgeryToken()] on Controller Action method will validate the generated token.

Hence, Hacking application will not have this hidden field code generated, and our application will unable to validate it throwing antiforgery validation error.
