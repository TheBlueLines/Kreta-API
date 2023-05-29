# Kréta API

Kréta API Library for C# applications (DOTNET 6.0)

## Kréta Engine
```csharp
Engine engine = new(string apiKey = "7856d350-1fda-45f5-822d-e1a2f3f1acf0", string userAgent = "KretaAPI");
```
## All institutes
```csharp
List<Institute> institutes = engine.Institutes();
```
## Login
```csharp
Account account = new(string instituteCode, string username, string password, string userAgent = "KretaAPI");
```
## refresh Token
```csharp
account.RefreshToken();
```
## Student Info
```csharp
StudentInfo studentInfo = account.student;
```
## Capabilities
```csharp
School school = account.capabilities;
```
## Lessons
```csharp
List<Lesson> lessons = account.Lessons(DateTime fromDate, DateTime toDate);
```
## Absences
```csharp
List<Omission> omissions = account.Omissions(DateTime fromDate, DateTime toDate);
```
## Evaluations
```csharp
List<Evaluation> evaluations = account.Evaluations(DateTime fromDate, DateTime toDate);
```
## Messages
```csharp
List<Message> messages = account.Messages(MessageType select);
```
## Exams
```csharp
List<AnnouncedTest> announcedTests = account.AnnouncedTests(DateTime fromDate, DateTime toDate);
```
## Homeworks
```csharp
List<Homework> homeworks = account.Homeworks(DateTime fromDate, DateTime toDate);
```
## Notes
```csharp
List<Note> notes = account.Notes(DateTime fromDate, DateTime toDate);
```