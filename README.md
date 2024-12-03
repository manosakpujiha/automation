# **Movies Zone Testing Plan**

## **Links**
- [GitHub Repo for Codebase](https://github.com/manosakpujiha/movies-zone)
- [Hosted Application](https://manos-movieszone.netlify.app/)

---

## **Group Information**

**Group Members**:
- **Manos Akpujiha** (A00289665)
- **Manpreet Kaur** (A00307693)
- **Gurkirat Singh Longia** (A00301269)
- **Ujjwal Manishkumar Patel** (A00312260)
- **Saurav Gyawali** (A00301312)

---

## **Application Description**

**Movies Zone** is a web application designed to serve as a comprehensive platform for users interested in watching the latest movie trailers and teasers. It offers an extensive library of trailers across various genres, enabling users to explore upcoming films and stay informed about new releases in the film industry.

**Purpose**:
To provide a centralized platform where movie enthusiasts can:
- **Stay Informed**: Access a curated collection of trailers for new and upcoming movies across various genres.
- **Discover Content**: Explore movies based on genres, trends, and user recommendations.

**Key Features**:
- **Extensive Trailer Library**: Users have access to a wide range of movie trailers from different genres, allowing for diverse exploration.
- **User Authentication**: The application supports user registration and login, enabling personalized experiences such as saving favorite trailers and receiving tailored recommendations.

---

## **Functional Test Cases**

### **Steps for Automation and Contributors**
- **Login**: Automating the process of logging in with valid credentials. **- Manos**
- **Register**: Testing the user registration flow with new credentials. **- Manpreet**
- **Visit the Profile Page**: Verify access to the profile page after login. **- Gurkirat**
- **Play a Trailer**: Automating the playback of a movie trailer. **- Ujjwal**
- **Read the Description of a Movie**: Validating that the movie description is correctly displayed. **- Saurav**

---

### **Test Cases**

| **Test Case ID** | **Description**                                | **Preconditions**                       | **Test Steps**                                                                                                                                   | **Expected Result**                                                                                                      |
|-------------------|-----------------------------------------------|-----------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------|
| **TC-FUNC-01**    | Automate the login process with valid credentials | User has a valid account; website is live | 1. Navigate to the login page.<br>2. Enter valid email and password.<br>3. Click the "Login" button.                                         | - User is redirected to the homepage or profile page.<br>- A "Welcome" message or username is displayed.                 |
| **TC-FUNC-02**    | Test user registration flow with new credentials | Website is live                         | 1. Navigate to the registration page.<br>2. Fill in the registration form with valid details.<br>3. Click the "Register" button.             | - User receives a confirmation message.<br>- New account is successfully created, and user is redirected to login.       |
| **TC-FUNC-03**    | Verify access to the profile page after login  | User is logged in                       | 1. Click on the "Profile" button or link from the navigation bar.                                                                             | - User is redirected to their profile page.<br>- Profile details are displayed correctly.                                |
| **TC-FUNC-04**    | Ensuring users can log out successfully        | User is logged in                       | 1. Click on the "Logout" button from the navigation bar or dropdown menu.                                                                     | - User is logged out.<br>- Redirected to the homepage or login page.<br>- "Logged out successfully" message displayed.   |
| **TC-FUNC-05**    | Automate the playback of a movie trailer       | User is on the movie details page       | 1. Navigate to a movie details page.<br>2. Click the "Play Trailer" button.                                                                  | - Movie trailer video starts playing.<br>- Video controls (play, pause, volume) are functional.                          |
| **TC-FUNC-06**    | Validate that the movie description is displayed correctly | User is on the movie details page       | 1. Navigate to a movie details page.<br>2. Check the "Description" section of the page.                                                      | - The movie description is displayed correctly.<br>- Description text matches the stored details in the database.         |

---

This testing plan outlines functional test cases designed to validate critical aspects of the **Movies Zone** application, ensuring it meets user expectations and delivers a reliable user experience.
