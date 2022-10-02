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
## Timetable
```csharp
List<Timetable> timetable = account.OrarendElemek(DateTime datumTol, DateTime datumIg);
```
## Absences
```csharp
List<Absences> absences = account.Mulasztasok(DateTime? datumTol = null, DateTime? datumIg = null);
```
## Evaluations
```csharp
List<Evaluations> evaluations = account.Ertekelesek(DateTime? datumTol = null, DateTime? datumIg = null);
```
## Messages
```csharp
List<Message> messages = account.Postaladaelemek(0 (received) or 1 (sent) or 2 (deleted));
```
## Exams
```csharp
List<Exam> exams = account.BejelentettSzamonkeresek(DateTime? datumTol = null);
```
## Student Info
```csharp
StudentInfo studentInfo = account.TanuloAdatlap();
```
## Homeworks
```csharp
List<Homework> homeworks = account.HaziFeladatok(DateTime? datumTol = null);
```
## Notes
```csharp
List<Note> notes = account.Feljegyzesek();
```
## Capabilities
```csharp
School school = account.Intezmenyek();
```