using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataObjects.Migrations.CBRDb
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<double>(type: "double", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "VoteMatch",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RedTeamID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BlueTeamID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoteMatch", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VoteMatch_Location_BlueTeamID",
                        column: x => x.BlueTeamID,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VoteMatch_Location_RedTeamID",
                        column: x => x.RedTeamID,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MatchResult",
                columns: table => new
                {
                    MatchID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    WinnerID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    LoserID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    submit_time = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchResult", x => x.MatchID);
                    table.ForeignKey(
                        name: "FK_MatchResult_Location_LoserID",
                        column: x => x.LoserID,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchResult_Location_WinnerID",
                        column: x => x.WinnerID,
                        principalTable: "Location",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchResult_VoteMatch_MatchID",
                        column: x => x.MatchID,
                        principalTable: "VoteMatch",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "ID", "Description", "ImageUrl", "Name", "Rating" },
                values: new object[,]
                {
                    { new Guid("019c94ae-43b7-4003-9e20-378fdece9c63"), "<html><body><p>EKU Housing &amp; Residence Life offers apartment-style living for upperclassmen students, which includes the conveniences of campus life.</p>\n<p>Grand Campus is a 500+ room apartment complex, open to EKU juniors, seniors and graduate students.</p>\n<p>Grand Campus offers a beautiful on-campus location with many amenities that are not found in standard traditional Residence Halls.</p></body></html>", "https://content.studentbridge.com/prod/259/79a0f7b2-2686-43d4-ac34-89565da0fa77.jpg", "Grand Campus Apartments", 1.0 },
                    { new Guid("04313655-b0cd-4e46-890d-829874a723cc"), "<html><body><p>With a welcoming lounge and a beautiful outdoor patio, Clay Hall is a great place to live at EKU.</p>\n<p>Centrally located, Clay Hall is convenient to Case Dining Hall, Powell Student Center and the new Science Building.</p>\n<p>Clay Hall offers enhanced traditional spaces that house two residents with a sink in the room and a community bathroom.</p>\n<p>Enhanced traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>", "https://content.studentbridge.com/prod/259/16463e69-b19b-436b-a389-161b69549e82.jpg", "Clay Hall", 1.0 },
                    { new Guid("05277880-cd29-49e8-b9d0-569ad5dc5681"), "<html><body><p>With convenient parking and a location that overlooks the Campus Beautiful, Telford Hall is a desired community for students who want suite-style living within a close-knit community.</p>\n<p>Telford offers traditional suite spaces where four residents share two bedrooms and a full bathroom, which connect the suite.</p></body></html>", "https://content.studentbridge.com/prod/259/6baf48af-f920-4845-9770-6ca95e8404ee.jpg", "Telford Hall", 1.0 },
                    { new Guid("1aa6b04e-164e-4ea0-a126-d4b20cb74983"), "<html><body><p>The Business &amp; Technology Center is home to EKU’s College of Business.</p>\n<p>We are one of the select few universities in the nation to house an AACSB-accredited School of Business along with an array of applied sciences programs, making diversity our competitive advantage.</p>\n<p>The BTC is home to programs in high-demand career fields.</p></body></html>", "https://content.studentbridge.com/prod/259/6582015f-4bb4-4884-b576-56e0c177614c.jpg", "Business and Technology Center", 1.0 },
                    { new Guid("1bb8f24a-9838-4fd1-a0a4-5f5dced1dba2"), "<html><body><p>The University Building, also known as Old Central, is the oldest building on campus and is listed in the National Register of Historic Places.</p>\n<p>It now houses the offices and classrooms for the Department of History, the EKU Honors Program, and is part of the Library’s new addition.</p></body></html>", "https://content.studentbridge.com/prod/259/75509ee2-7ac3-46e4-a080-14684c8c562a.jpg", "University Building", 1.0 },
                    { new Guid("1eaf7bba-e307-403e-801a-4ea0b44d4a8c"), "<html><body><p>Located in the heart of EKU’s Richmond Campus, the Keen Johnson Building plays host to numerous kinds of events.</p>\n<p>The Ballroom and Walnut Hall are the perfect size for large social gatherings, while the East, South and West halls on the second floor are great for smaller conferences and meetings.</p>\n<p>There is even a small performance space, the Pearl Buchanan Theater, available for small on-campus groups.</p>\n<p>Keen Johnson is also located near EKU’s Daniel Boone statue.</p>\n<p>Daniel Boone’s golden toe is said to give students, faculty and staff good luck.</p></body></html>", "https://content.studentbridge.com/prod/259/950d4284-6820-4dec-b98d-106cc397edc6.jpg", "Keen Johnson Building", 1.0 },
                    { new Guid("20130a81-c236-4a9c-9d43-0440e653b4f3"), "<html><body><p>The Campbell Building is home to the Department of Art, EKU Theatre and the C.H. Gifford Theatre.</p>\n<p>Inside Campbell, plays, concerts and musical productions are held in the 475-seat theatre.</p>\n<p>Also found in the lobby of the Campbell Building is the Fred P. Giles Art Gallery.</p></body></html>", "https://content.studentbridge.com/prod/259/331e62c3-67ad-4afd-aafa-aa576460641b.jpg", "Campbell Building", 1.0 },
                    { new Guid("276bb674-65ca-44dc-abbd-b43c0cd99195"), "<html><body><p>Our brand-new Student Recreation Center provides students with everything they need to stay fit and have fun.</p>\n<p>Exercise and get involved in a variety of ways with three hardwood multi-purpose sports courts lined for basketball and volleyball; one multi-activity gym, lined for indoor soccer, hockey, handball, basketball or volleyball; three racquetball or wallyball courts; a cardio and fitness area and an elevated indoor track.</p>\n<p>There are also three group fitness studios where students can participate in yoga, HIIT, Zoomba and more.</p>\n<p>We even have our own indoor/outdoor climbing bouldering center, an aquatics center, and an esports lounge.</p>\n<p>Not to mention full locker rooms and sauna.</p>\n<p>Fun fact! All the games are free for EKU students, and most offer free t-shirts.</p></body></html>", "https://content.studentbridge.com/prod/259/eec45fb2-6dc4-4210-a894-cf62530daf25.jpg", "Student Recreation Center", 1.0 },
                    { new Guid("3743681c-9e61-48ee-87e2-bef623b684da"), "<html><body><p>The Combs Building is home to the Department of Education, public relations, and some broadcasting and electronic media courses.</p>\n<p>Combs includes lecture-hall style classrooms, each built like a small auditorium.</p>\n<p>Every hour during the regular semester, more than 2,000 students are in class here.</p></body></html>", "https://content.studentbridge.com/prod/259/3028289c-062c-4847-a75b-77f615e4b903.jpg", "Combs Building", 1.0 },
                    { new Guid("3889c793-aa41-4f8a-989c-36b2e19f8891"), "<html><body><p>For half a century, Roy Kidd Stadium has been a cornerstone for Eastern Kentucky University and Colonel athletics.</p>\n<p>The stadium has been host to millions of fans, pivotal games and many campus activities.</p>\n<p>With recent improvements, Roy Kidd Stadium is now better served to meet the needs of EKU’s student-athletes, the university and the community.</p></body></html>", "https://content.studentbridge.com/prod/259/8d1cda0d-6a40-49ee-948a-cca003943f8d.jpg", "Roy Kidd Stadium", 1.0 },
                    { new Guid("3ce589dc-18d9-45e9-9264-ce3ea5c8ddd4"), "<html><body><p>The Wallace Building, located conveniently to Case Dining Hall, is home to EKU’s Math and Statistics Department, EKU’s communication disorders program, American Sign Language and interpretation programs, and English courses.</p>\n<p>Wallace houses two large lecture halls located on the ground floor, where students may have classes.</p></body></html>", "https://content.studentbridge.com/prod/259/eab71bd6-c335-49b0-a897-f2d5bcf5f689.jpg", "Wallace Building", 1.0 },
                    { new Guid("426f96a5-d7a0-4fa6-98a0-e8d8b88baf30"), "<html><body><p>Palmer Hall is the perfect community for students who want a central campus location!</p>\n<p>Located directly next to the brand-new campus recreation center and just steps from the Powell Student Center and Case Dining Hall, Palmer Hall is a perfect location to enjoy campus conveniences.</p>\n<p>Palmer Hall offers traditional spaces which house two residents per room and offer a community bathroom.</p>\n<p>Traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>", "https://content.studentbridge.com/prod/259/8c91eaaf-2561-44b7-9947-7e80c244a78b.jpg", "Palmer Hall", 1.0 },
                    { new Guid("44f219f8-782d-42cc-9864-566a1533fe2e"), "<html><body><p>The Whalin Technology Complex and the Central Kentucky Regional Airport are located just a few miles from campus.</p>\n<p>Whalin is a series of buildings that houses classrooms and labs for courses that are a part of the College of Science, Technology, Engineering, and Mathematics.</p>\n<p>As a student, you can pursue careers in high-demand fields like aviation, applied engineering management, construction management and more.</p>\n<p>Co-ops and internships, along with well-connected faculty, give our students a competitive edge.</p>\n<p>Our aviation program is one of the most affordable in the nation and is the only one of its kind in Kentucky.</p></body></html>", "https://content.studentbridge.com/prod/259/dc577912-af03-41d1-aa5e-10e00afe36bf.jpg", "Whalin Complex", 1.0 },
                    { new Guid("4542190b-f5ba-4065-8386-e1376664a770"), "<html><body><p>The A.B. Carter Building is home to EKU Agriculture, offering various degrees in agriculture and a pre-veterinary medicine program.</p>\n<p>Modern facilities like the greenhouses and our very own Meadowbrook Farm provide hands-on learning experiences.</p></body></html>", "https://content.studentbridge.com/prod/259/fcf3a377-cb46-411f-8489-18db2c0b2431.jpg", "Carter Building", 1.0 },
                    { new Guid("516fe894-b76e-4070-b828-796bfccc883d"), "<html><body><p>The Forensic Crime Scene House is used primarily by Forensic Science students for hands on experience in the field.\r\n</p></body></html>", "https://content.studentbridge.com/prod/259/17022996-c63c-4ca8-9cae-c847533816c0.jpg", "Forensic Crime Scene House", 1.0 },
                    { new Guid("53096dd4-e62f-4542-8ec2-ab060f29d993"), "<html><body><p>Burnam Hall is located across the historic Ravine and close to the newly renovated Case Dining Hall and Powell Student Center.</p>\n<p>Burnam is a unique residence hall, offering many different housing styles for students, including spaces with traditional, enhanced traditional, and suite-style options.</p></body></html>", "https://content.studentbridge.com/prod/259/5dfaf0ca-0e4d-41ea-bfaa-ffabe5b04b17.jpg", "Burnam Hall", 1.0 },
                    { new Guid("5545976b-5f94-4127-94a4-be7d9ca98e23"), "<html><body><p>Moberly is home to our two-time national champion football program, our national championship co-ed and all-girl cheerleading program, as well as our athletic training, exercise and sport science, and pre-physical therapy programs.\r\n</p></body></html>", "https://content.studentbridge.com/prod/259/0f77428b-cdd4-40a2-bb79-09a5cfca2d7c.jpg", "Moberly Building", 1.0 },
                    { new Guid("57d23290-a984-47e0-a196-49d1d5d2d0a2"), "<html><body><p>Built in 1909, the Roark Building was originally home to the Model Laboratory School at Eastern.</p>\n<p>Today, the building houses the Departments of Earth Sciences, Geography and Planning, and the Dean’s Office for the College of Letters, Arts, and Social Sciences.</p></body></html>", "https://content.studentbridge.com/prod/259/ad26aaec-0b58-4540-8657-1d185b4f94f9.jpg", "Roark Building", 1.0 },
                    { new Guid("5d9a7ea1-1102-4849-9596-efcea45e626e"), "<html><body><p>Sullivan Hall is known for its warm and welcoming front porch.</p>\n<p>With a beautiful view of the historic Ravine and centrally located within walking distance to Case Dining Hall, Powell Student Center and the Crabbe Library, Sullivan Hall is perfect for students who want to be in the middle of the action at EKU.</p>\n<p>Sullivan Hall offers larger than normal traditional spaces, which house two residents per room and offers a community bathroom.</p>\n<p>Traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>", "https://content.studentbridge.com/prod/259/cf9fbf30-494f-4850-8e95-7504ae6d1774.jpg", "Sullivan Hall", 1.0 },
                    { new Guid("5edba6fe-9cbb-400f-9211-57222009c624"), "<html><body><p>Martin Hall is home to more than 600 students and overlooks the beautiful Carloftis Gardens, designed by nationally acclaimed rooftop garden designer John Carloftis.</p>\n<p>Martin joins four other newly constructed residence halls, bringing the total number to 12.</p>\n<p>This allows more than 5,000 students the opportunity to live alongside their fellow Colonels on the Campus Beautiful.</p>\n<p>With a variety of amenities and all located within a 10-minute walk to most classes, you’re sure to find a perfect fit for you.</p></body></html>", "https://content.studentbridge.com/prod/259/55549cee-1d17-428b-aef9-cd07d5d20c43.jpg", "Martin Hall", 1.0 },
                    { new Guid("63a16478-5413-4371-b01f-4264c32a166e"), "<html><body><p>The Ashland Fire and Safety Laboratory houses our fire and safety programs, including fire protection administration; fire, arson and explosion investigation; and fire protection and safety engineering technology.</p>\n<p>The Ashland Building is home to a fire protection system lab, fire extinguisher service lab and a multi-purpose high-bay lab.</p>\n<p>The newest addition is a seven-room test burn facility.</p></body></html>", "https://content.studentbridge.com/prod/259/a3411bd3-612e-4381-a04a-32da09b0cadb.jpg", "Ashland Building", 1.0 },
                    { new Guid("6419ac76-eff6-405a-a490-1526e46743a3"), "<html><body><p>Nestled in the center of campus, McGregor Hall is an exciting place to live!</p>\n<p>McGregor is located in the center of campus, convenient to the Library, Powell Student Center, and Case Dining Hall.</p>\n<p>McGregor Hall offers double rooms which house two residents.</p>\n<p>The rooms are equipped with a sink and two built-in wardrobes.</p>\n<p>Convenient community bathrooms are located on each floor.</p></body></html>", "https://content.studentbridge.com/prod/259/6515989a-2192-4082-9dc9-ba2d4552ae3a.jpg", "McGregor Hall", 1.0 },
                    { new Guid("780865f8-1863-4a60-be20-6f8715fc9896"), "<html><body><p>Our Powell Student Center is home to various resources, including Student Life &amp; First-Year Experience, the Center for Inclusive Excellence and Global Engagement (CIEGE), and our very own Vets|Ready Center for our military and veteran students.</p>\n<p>This facility also hosts a U.S. Bank, Starbucks, spacious lounge study spaces and more.</p></body></html>", "https://content.studentbridge.com/prod/259/36df5282-93f2-4b4c-b9ee-e81d300b3044.jpg", "Powell Student Center", 1.0 },
                    { new Guid("79e58b12-30a4-49f8-8634-57f299ebffd6"), "<html><body><p>Model Laboratory School is one of the top K-12 schools in the state, which allows our education students to get into the classroom within their first semester.</p>\n<p>Originally known as Eastern Kentucky State Teachers College, EKU owes its foundation to teaching.</p>\n<p>In addition to elementary, middle and high school teaching programs, EKU is home to a nationally recognized American Sign Language program, an outstanding communication disorders curriculum, and an early childhood special education program.</p></body></html>", "https://content.studentbridge.com/prod/259/866d53ec-b681-4ba8-a639-2a9f9c66b40c.jpg", "Model Laboratory School", 1.0 },
                    { new Guid("86cf5cba-c99f-4357-98fa-65835c136582"), "<html><body><p>Whether you prefer the relative quiet of a small town or the buzz of a bigger city, living in Richmond offers the best of both worlds.</p>\n<p>Richmond is a fast-growing yet quiet community where the Bluegrass region and its scenic horse farms meet the foothills of the rugged Appalachian Mountains.</p>\n<p>Just 25 miles North, an easy drive on I-75, is Kentucky’s second-largest city: Lexington.</p>\n<p>Other large cities within an easy two-hour drive are Louisville, Kentucky; Cincinnati, Ohio and Knoxville, Tennessee.</p></body></html>", "", "Main Street - Richmond, KY", 1.0 },
                    { new Guid("87f888e7-2c36-47cd-9e3f-122ca4cbd34f"), "<html><body><p>Located next to the EKU Center for the Arts, Keene Hall offers a convenient location to the Business &amp; Technology Center; the College of Justice, Safety &amp; Military Science and the Perkins Building.</p>\n<p>With affordable living, a close-knit community and large outdoor patio spaces (including a sand volleyball court), students develop close bonds and build strong relationships.</p>\n<p>Keene Hall offers traditional spaces housing two residents per room and offering a community bathroom.</p>\n<p>Traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>", "https://content.studentbridge.com/prod/259/48bdeb25-ca5a-48e8-b827-7d80039bf716.jpg", "Keene Hall", 1.0 },
                    { new Guid("8b20d909-63f4-40dc-baa3-702f17e66639"), "<html><body><p>The Carloftis Garden is located near the intersection of Lancaster and Park Drive and fronting new Martin Hall.</p>\n<p>The Carloftis Garden is the first on any public university campus to bear the stamp of Jon Carloftis, an internationally renowned landscape designer who grew up in Rockcastle County and became known as “Gardener to the Stars.”</p>\n<p>The Carloftis Garden is also home to the Divine Nine Plaza: a reminder to future generations of the important role that NPHC fraternities and sororities continue to play in shaping young lives.</p></body></html>", "https://content.studentbridge.com/prod/259/2edc4839-b593-4a92-80c0-a3d4a79043f2.jpg", "Carloftis Gardens", 1.0 },
                    { new Guid("8b37e9a4-a992-44f3-bb46-ff9e5383b17a"), "<html><body><p>Also known as the Ski Lodge, Walters Hall has a warm and inviting interior lobby with plenty of space for socializing, hall programs and studying.</p>\n<p>Conveniently located next to EKU's Caffeinated Colonel Coffee Shop, Walters Hall is just a short walk to Case Dining Hall, the historic Ravine and Crabbe Library.</p>\n<p>Walters Hall offers enhanced traditional spaces which house two residents including a sink in the room and a community bathroom.</p>\n<p>Enhanced traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>", "https://content.studentbridge.com/prod/259/1984c862-cb07-46fe-b105-f24ca7e141de.jpg", "Walters Hall", 1.0 },
                    { new Guid("92db5f3f-68db-4366-95a5-dbd0399f7cca"), "<html><body><p>The Burrier Building, located on the corner of University Drive and Crabbe Street, is home to the Departments of Family and Consumer Sciences Education, Child and Family Studies, and Food and Nutrition.</p>\n<p>Burrier also houses the Burrier Cafe and the Burrier Child Development Center.</p></body></html>", "https://content.studentbridge.com/prod/259/d9bef125-1b26-4e6d-b27f-5b8f08cff2df.jpg", "Burrier Building", 1.0 },
                    { new Guid("967a2a1a-7a65-4710-8d7f-6b97f7990808"), "<html><body><p>The McCreary Building, located by Turner Gate, is home to the Bobby Verdugo and Yoli Rios Bilingual Peer Mentor and Tutoring Center.</p>\n<p>This center provides tutoring for languages and other subjects along with mentoring for students.</p></body></html>", "https://content.studentbridge.com/prod/259/5694ad2e-5737-4fd5-a1d3-ff23bbd6c8b3.jpg", "McCreary Building", 1.0 },
                    { new Guid("96948b74-8322-4966-8fce-f292b8cae0bb"), "<html><body><p>Case Dining Hall houses the brand-new Case Kitchen located on the second floor.</p>\n<p>Case Kitchen features full access breakfast, lunch or dinner with international entrees, a grill, deli, salad bar and more.</p>\n<p>Case Food Court just downstairs, is a place to meet, greet and eat between classes.</p>\n<p>Students can dine in or take out various options: Chick-fil-A, Subway, Moe’s Southwest Grill, Panda Express and a convenient POD Market to quickly grab some things and take them back to your residence hall.</p></body></html>", "https://content.studentbridge.com/prod/259/2d1966bf-6a71-4634-a241-e66fe9f270f9.jpg", "Case Dining Hall", 1.0 },
                    { new Guid("979a29e9-bf33-42f4-864b-49da878f2fc2"), "<html><body><p>The EKU Center for the Arts is Central Kentucky's premier live entertainment and arts destination, located conveniently off I-75 in Richmond.</p>\n<p>The Center for the Arts is home to premier artistic productions, community outreach opportunities and educational programming.</p></body></html>", "https://content.studentbridge.com/prod/259/a341dd54-6b8d-4fac-a691-5ce39e207cf7.jpg", "Center for the Arts", 1.0 },
                    { new Guid("989ce32f-162d-4728-aae0-ff20e8c8caef"), "<html><body><p>The Weaver Health Building, located conveniently across from the Whitlock Building, is primarily occupied by EKU ROTC and the exercise and sport science program.</p>\n<p>There is an in-ground swimming pool in the basement of the Weaver Building and dance studios, a gymnasium and the Faculty Fitness and Wellness Center.</p></body></html>", "https://content.studentbridge.com/prod/259/2024b78f-55f1-4a32-b0da-d3612518c7bc.jpg", "Weaver Building", 1.0 },
                    { new Guid("99d11b57-0aeb-4b82-b37c-6ddd94955155"), "<html><body><p>The Crabbe Library is sectioned by noise level and has many dynamic study areas to help meet each student’s individual needs – including our very own Student Success Center, a one-stop shop for EKU students.</p>\n<p>The Noel Studio for Academic Creativity offers innovative support for communication, research, teaching and learning initiatives that enhance deep learning at EKU.</p>\n<p>We don’t stop there.</p>\n<p>There’s also a music library in the Foster Building and a library in our Business &amp; Technology Center.</p>\n<p>The Crabbe Library also hosts workshops for students and stays open 24/7 around finals.</p></body></html>", "https://content.studentbridge.com/prod/259/34f6fc58-5288-4716-ae3d-aae79f50233c.jpg", "Crabbe Library", 1.0 },
                    { new Guid("b141b96f-155a-4a6a-9d77-4937f4566d22"), "<html><body><p>We are now at an iconic EKU space, the Ravine.</p>\n<p>This outdoor earth-carved arena is considered the heart and soul of campus.</p>\n<p>Constructed in the 1920s, the Ravine is used for plays, concerts, classes, and Rec the Ravine, an annual event hosted by Campus Recreation.</p>\n<p>As you can see, this space is loved by all students and used as a great relaxation space.</p>\n<p>It's just another reason we are called the Campus Beautiful.</p></body></html>", "https://content.studentbridge.com/prod/259/474f7303-7e6d-4867-807c-7c72cf188dc9.jpg", "Ravine", 1.0 },
                    { new Guid("d20690f3-51c8-47eb-869a-d621dad111fe"), "<html><body><p>The Dizney Building is the center of the College of Health Sciences and home to our nationally ranked occupational therapy and nursing programs.</p>\n<p>Students can also earn degrees in environmental health science, medical laboratory science, health services administration, and more.</p></body></html>", "https://content.studentbridge.com/prod/259/931c722a-6668-48ce-9c98-f842b5d4a6bf.jpg", "Dizney Building", 1.0 },
                    { new Guid("d22e5cf4-32a3-48d1-a645-555a71fc3b97"), "<html><body><p>The Foster Music Building is named after the composer of \"My Old Kentucky Home.\"</p>\n<p>Its spaces range from practice rooms to studios to classrooms.</p>\n<p>The School of Music presents more than 100 concerts annually, including ensemble, faculty and guest artist performances.</p>\n<p>While the Music Department offers several degree options, you don’t have to be a part of the department to get involved with music on campus.</p>\n<p>Fun fact! EKU’s Foster Music Camp held each summer for middle and high-school students is the second oldest music camp in the nation.</p></body></html>", "https://content.studentbridge.com/prod/259/6614dbca-5c33-4823-b459-a4bb8c075d0f.jpg", "Foster Music Building", 1.0 },
                    { new Guid("d596745f-b682-43c0-907c-e415e1426f97"), "<html><body><p>The Stratton Building is home to EKU’s program of distinction, the College of Justice, Safety, and Military Science.</p>\n<p>The School of Justice Studies offers majors in criminal justice, police studies, social justice studies and more.</p>\n<p>Since 1972, the School of Safety, Security, and Emergency Management programs have been the first choice for students around the world.</p>\n<p>Offering students options in homeland security, occupational safety, and emergency management, we graduate some of the country’s most in-demand safety and security professionals.</p></body></html>", "https://content.studentbridge.com/prod/259/fadb3d1a-68d2-422a-bc0d-f615f05ae039.jpg", "Stratton Building", 1.0 },
                    { new Guid("d9bbfd49-5fe6-46dc-b3fb-73217b0717d7"), "<html><body><p>The Eastern Scholar House opened in the fall of 2017.</p>\n<p>It offers a transformative experience for single parents pursuing a college education.</p>\n<p>Located in the 800 area of Brockton, near the university’s Fitness and Wellness Center, the Scholar House is the product of a partnership between the Kentucky Housing Corporation (KHC), Kentucky River Foothills Development Council Inc. (KRFDC), the City of Richmond and EKU.</p>\n<p>The Scholar House is a one-stop shop of services for single parents, including access to an on-site childhood development facility, counseling services, life-skills workshops, and proximity to EKU’s Student Health Services and Women’s Clinic.</p></body></html>", "https://content.studentbridge.com/prod/259/cf9286a7-06c6-488c-acdf-7fc4881d359c.jpg", "Eastern Scholar House", 1.0 },
                    { new Guid("de2ea3a0-866a-4f00-9345-3dc467c91930"), "<html><body><p>We’ve now come across EKU’s $130 million, 330,000 square-foot Science Building.</p>\n<p>This state-of-the-art space houses the Departments of Chemistry, Biology, Geoscience, Physics, and Astronomy.</p>\n<p>STEM majors can get unparalleled hands-on experience in top-notch laboratories and classrooms.</p>\n<p>One of our premier programs, forensic science, is also in this building.</p>\n<p>Established in 1974, it’s only one of 18 accredited programs in the country.</p></body></html>", "https://content.studentbridge.com/prod/259/c479750c-c324-4f1a-b6ad-a814d334b673.jpg", "New Science Building", 1.0 },
                    { new Guid("e2967e22-7d37-45a9-b9da-fbd6320b7e5f"), "<html><body><p>The Rowlett Building is a three-story, 53,000-square-foot facility housing the Department of Associate Degree Nursing, the Department of Baccalaureate and Graduate Nursing, and the Health Professions Learning Resource Center.</p>\n<p>Rowlett also houses a state-of-the-art simulation lab for all EKU allied health students to use and EKU’s Student Health Services Clinic.</p></body></html>", "https://content.studentbridge.com/prod/259/7401d340-583d-4774-8b01-41c6a192ee7a.jpg", "Rowlett Building", 1.0 },
                    { new Guid("e70ef9a6-faf0-4031-a662-88cf30e1e14e"), "<html><body><p>South Hall is conveniently located on Kit Carson Drive between the Science Building and North Hall.</p>\n<p>South Hall serves as a break hall, staying open during all breaks throughout the fall, winter and spring months.</p>\n<p>South Hall offers two floor-plan options: two bedrooms with access to a small living room/kitchenette area and shared bathroom, and four bedrooms with access to a small living room/kitchenette area and shared bathroom.</p></body></html>", "https://content.studentbridge.com/prod/259/721808d4-5363-41d0-b74c-73f1009e64b9.jpg", "South Hall", 1.0 },
                    { new Guid("ee7c437c-ef1b-4a89-980f-cdeb59ca3c00"), "<html><body><p>Turner Gate is the main pedestrian entrance to the university and the beginning of a new student tradition.</p>\n<p>All entering freshmen pass through the gate during the Big E Welcome.</p>\n<p>Students pass the pillars of Wisdom and Knowledge, symbolizing everything they will gain from their Eastern experience.</p></body></html>", "https://content.studentbridge.com/prod/259/84c10ff4-175b-4f98-ad48-25d735c43d9e.jpg", "Turner Gate", 1.0 },
                    { new Guid("f18ec3c1-36ef-45fb-9406-f05548757720"), "<html><body><p>Situated near the Science Buildings and adjacent to South Hall, North Hall is just steps away from Case Dining Hall and the Powell Student Center.</p>\n<p>North Hall offers simple suite spaces that house four residents between two bedrooms connected by a full bathroom.</p>\n<p>North Hall also offers two bedrooms shared by two students who each share a bathroom.</p>\n<p>The bedrooms are connected by a common living space and a kitchenette.</p></body></html>", "https://content.studentbridge.com/prod/259/918c7043-8270-430e-862b-074482c6b3c4.jpg", "North Hall", 1.0 },
                    { new Guid("f547b963-49f6-440f-9bb1-180b80e33a77"), "<html><body><p>The Charles D. Whitlock Building houses all the student services you’ll need, from application to graduation.</p>\n<p>Whitlock is home to offices such as Admissions, Financial Aid &amp; Scholarships, Housing &amp; Residential Life, Student Outreach &amp; Transition, and many others.</p>\n<p>Whether you come to campus for your first visit or a special event, your day will begin in our Welcome Center.</p></body></html>", "https://content.studentbridge.com/prod/259/9fbfc01a-c74d-40fa-83f8-d5ad525a6ce5.jpg", "Whitlock Building", 1.0 },
                    { new Guid("f83f0a46-dfa8-43bb-bd06-072c0e1c6d23"), "<html><body><p>The Alumni Coliseum, also known as the Paul S. McBrayer Arena, has been home to EKU Colonel basketball since the 1963-64 season and volleyball since 1991.</p>\n<p>Alumni Coliseum seats 6,500 fans for sporting events and around 8,000 individuals for events, including graduation ceremonies.</p></body></html>", "https://content.studentbridge.com/prod/259/df0fa49c-828e-47c4-bcd9-59bedab5eb37.jpg", "Alumni Coliseum", 1.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchResult_LoserID",
                table: "MatchResult",
                column: "LoserID");

            migrationBuilder.CreateIndex(
                name: "IX_MatchResult_WinnerID",
                table: "MatchResult",
                column: "WinnerID");

            migrationBuilder.CreateIndex(
                name: "IX_VoteMatch_BlueTeamID",
                table: "VoteMatch",
                column: "BlueTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_VoteMatch_RedTeamID",
                table: "VoteMatch",
                column: "RedTeamID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchResult");

            migrationBuilder.DropTable(
                name: "VoteMatch");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
