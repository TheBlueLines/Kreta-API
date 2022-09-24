# Kréta API

Kréta API Library for C# applications (DOTNET 6.0)

## Login
```csharp
Account? account = new(string instituteCode, string username, string password);
```
## refresh Token
```csharp
me.RefreshToken();
```
## Get Timetable
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
## Get all messages
```csharp
List<Message> messages = account.Postaladaelemek(0 (received) or 1 (sent) or 2 (deleted));
```
## Exams
```csharp
List<Exam> exams = account.BejelentettSzamonkeresek(DateTime? datumTol = null);
```
## Exams
```csharp
StudentInfo studentInfo = account.TanuloAdatlap();
```