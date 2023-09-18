# Kréta API

Kréta API Library for C# applications (DOTNET 7.0)

## Global API
```csharp
GlobalApi globalApi = new GlobalApi();
```
### All institutes
```csharp
globalApi.GetInstitutes();
```
## IDP
```csharp
IDP idp = new IDP();
```
### Login
```csharp
Authentication authentication = idp.Login(string instituteCode, string username, string password);
```
### refresh Token
```csharp
Authentication authentication = idp.RefreshToken(string instituteCode, string refreshToken);
```
## MobileAPI
```csharp
MobileApi mobileApi = new(string instituteCode, string accessToken);
```
### Get announced tests
```csharp
List<AnnouncedTest> announcedTests = mobileApi.GetAnnouncedTests(DateTime? fromDate = null, DateTime? toDate = null);
```
#### Get class average
```csharp
List<ClassAverage> classAverages = mobileApi.GetClassAverage(string taskUid, string? subjectUid = null);
```
### Get class master
```csharp
List<ClassMaster> classMasters = mobileApi.GetClassMaster(object? uids = null);
```
### Get consulting hour
```csharp
ConsultingHour consultingHour = mobileApi.GetConsultingHour(object uid);
```
### Get consulting hours
```csharp
List<ConsultingHourList> consultingHourLists = mobileApi.GetConsultingHours(DateTime? fromDate = null, DateTime? toDate = null);
```
### Get device given state
```csharp
bool deviceGivenState = mobileApi.GetDeviceGivenState();
```
### Get evaluations
```csharp
List<Evaluation> evaluations = mobileApi.GetEvaluations(DateTime? fromDate = null, DateTime? toDate = null);
```
### Get groups
```csharp
List<Group> groups = mobileApi.GetGroups();
```
### Get guardian
```csharp
Guardian4T guardian4T = mobileApi.GetGuardian4T();
```
### Get homeworks
```csharp
List<Homework> homeworks = mobileApi.GetHomeworks(DateTime? fromDate = null, DateTime? toDate = null);
```
### Get homework
```csharp
Homework homework = mobileApi.GetHomework(object id);
```
### Get LEP events
```csharp
List<LepEvent> lepEvents = mobileApi.GetLEPEvents();
```
### Get lesson
```csharp
Lesson lessons = mobileApi.GetLesson(object uid);
```
### Get lessons
```csharp
List<Lesson> lessons = mobileApi.GetLessons(DateTime? fromDate = null, DateTime? toDate = null);
```
### Get notes
```csharp
List<Note> notes = mobileApi.GetNotes(DateTime? fromDate = null, DateTime? toDate = null);
```
### Get notice board items
```csharp
List<NoticeBoardItem> noticeBoardItems = mobileApi.GetNoticeBoardItems();
```
### Get omissions
```csharp
List<Omission> omissions = mobileApi.GetOmissions(DateTime? fromDate = null, DateTime? toDate = null);
```
### Get registration state
```csharp
bool registrationState = mobileApi.GetRegistrationState();
```
### Get school year calendar
```csharp
SchoolYearCalendarEntry schoolYearCalendarEntry = mobileApi.GetSchoolYearCalendar();
```
### Get student
```csharp
Student student = mobileApi.GetStudent();
```
### Get subject average
```csharp
List<SubjectAverage> subjectAverages = mobileApi.GetSubjectAverage(object uid);
```
### Get time table weeks
```csharp
List<TimeTableWeek> timeTableWeeks = mobileApi.GetTimeTableWeeks(DateTime fromDate, DateTime toDate);
```