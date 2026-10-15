## Error handling: exceptions + global handler
Services throw domain-specific exceptions. One IExceptionHandler in the Api
project maps them to ProblemDetails (409 duplicate email, 401 invalid credentials).
Why: keeps service methods simple and puts HTTP concerns in one place.