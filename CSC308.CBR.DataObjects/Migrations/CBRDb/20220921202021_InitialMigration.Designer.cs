﻿// <auto-generated />
using System;
using CSC308.CBR.DataObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSC308.CBR.DataObjects.Migrations.CBRDb
{
    [DbContext(typeof(CBRContext))]
    [Migration("20220921202021_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSC308.CBR.DataObjects.DbLocation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("rating")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            ID = 4138,
                            Description = "<html><body><p>The Ashland Fire and Safety Laboratory houses our fire and safety programs, including fire protection administration; fire, arson and explosion investigation; and fire protection and safety engineering technology.</p>\n<p>The Ashland Building is home to a fire protection system lab, fire extinguisher service lab and a multi-purpose high-bay lab.</p>\n<p>The newest addition is a seven-room test burn facility.</p></body></html>",
                            Name = "Ashland Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4140,
                            Description = "<html><body><p>The Burrier Building, located on the corner of University Drive and Crabbe Street, is home to the Departments of Family and Consumer Sciences Education, Child and Family Studies, and Food and Nutrition.</p>\n<p>Burrier also houses the Burrier Cafe and the Burrier Child Development Center.</p></body></html>",
                            Name = "Burrier Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4142,
                            Description = "<html><body><p>The Business &amp; Technology Center is home to EKU’s College of Business.</p>\n<p>We are one of the select few universities in the nation to house an AACSB-accredited School of Business along with an array of applied sciences programs, making diversity our competitive advantage.</p>\n<p>The BTC is home to programs in high-demand career fields.</p></body></html>",
                            Name = "Business and Technology Center",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4143,
                            Description = "<html><body><p>The Campbell Building is home to the Department of Art, EKU Theatre and the C.H. Gifford Theatre.</p>\n<p>Inside Campbell, plays, concerts and musical productions are held in the 475-seat theatre.</p>\n<p>Also found in the lobby of the Campbell Building is the Fred P. Giles Art Gallery.</p></body></html>",
                            Name = "Campbell Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4145,
                            Description = "<html><body><p>The A.B. Carter Building is home to EKU Agriculture, offering various degrees in agriculture and a pre-veterinary medicine program.</p>\n<p>Modern facilities like the greenhouses and our very own Meadowbrook Farm provide hands-on learning experiences.</p></body></html>",
                            Name = "Carter Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4154,
                            Description = "<html><body><p>The Combs Building is home to the Department of Education, public relations, and some broadcasting and electronic media courses.</p>\n<p>Combs includes lecture-hall style classrooms, each built like a small auditorium.</p>\n<p>Every hour during the regular semester, more than 2,000 students are in class here.</p></body></html>",
                            Name = "Combs Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4155,
                            Description = "<html><body><p>The Crabbe Library is sectioned by noise level and has many dynamic study areas to help meet each student’s individual needs – including our very own Student Success Center, a one-stop shop for EKU students.</p>\n<p>The Noel Studio for Academic Creativity offers innovative support for communication, research, teaching and learning initiatives that enhance deep learning at EKU.</p>\n<p>We don’t stop there.</p>\n<p>There’s also a music library in the Foster Building and a library in our Business &amp; Technology Center.</p>\n<p>The Crabbe Library also hosts workshops for students and stays open 24/7 around finals.</p></body></html>",
                            Name = "Crabbe Library",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4156,
                            Description = "<html><body><p>The Dizney Building is the center of the College of Health Sciences and home to our nationally ranked occupational therapy and nursing programs.</p>\n<p>Students can also earn degrees in environmental health science, medical laboratory science, health services administration, and more.</p></body></html>",
                            Name = "Dizney Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4160,
                            Description = "<html><body><p>The Forensic Crime Scene House is used primarily by Forensic Science students for hands on experience in the field.\r\n</p></body></html>",
                            Name = "Forensic Crime Scene House",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4161,
                            Description = "<html><body><p>The Foster Music Building is named after the composer of \"My Old Kentucky Home.\"</p>\n<p>Its spaces range from practice rooms to studios to classrooms.</p>\n<p>The School of Music presents more than 100 concerts annually, including ensemble, faculty and guest artist performances.</p>\n<p>While the Music Department offers several degree options, you don’t have to be a part of the department to get involved with music on campus.</p>\n<p>Fun fact! EKU’s Foster Music Camp held each summer for middle and high-school students is the second oldest music camp in the nation.</p></body></html>",
                            Name = "Foster Music Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4167,
                            Description = "<html><body><p>The McCreary Building, located by Turner Gate, is home to the Bobby Verdugo and Yoli Rios Bilingual Peer Mentor and Tutoring Center.</p>\n<p>This center provides tutoring for languages and other subjects along with mentoring for students.</p></body></html>",
                            Name = "McCreary Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4172,
                            Description = "<html><body><p>Moberly is home to our two-time national champion football program, our national championship co-ed and all-girl cheerleading program, as well as our athletic training, exercise and sport science, and pre-physical therapy programs.\r\n</p></body></html>",
                            Name = "Moberly Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4173,
                            Description = "<html><body><p>Model Laboratory School is one of the top K-12 schools in the state, which allows our education students to get into the classroom within their first semester.</p>\n<p>Originally known as Eastern Kentucky State Teachers College, EKU owes its foundation to teaching.</p>\n<p>In addition to elementary, middle and high school teaching programs, EKU is home to a nationally recognized American Sign Language program, an outstanding communication disorders curriculum, and an early childhood special education program.</p></body></html>",
                            Name = "Model Laboratory School",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4174,
                            Description = "<html><body><p>We’ve now come across EKU’s $130 million, 330,000 square-foot Science Building.</p>\n<p>This state-of-the-art space houses the Departments of Chemistry, Biology, Geoscience, Physics, and Astronomy.</p>\n<p>STEM majors can get unparalleled hands-on experience in top-notch laboratories and classrooms.</p>\n<p>One of our premier programs, forensic science, is also in this building.</p>\n<p>Established in 1974, it’s only one of 18 accredited programs in the country.</p></body></html>",
                            Name = "New Science Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4180,
                            Description = "<html><body><p>Built in 1909, the Roark Building was originally home to the Model Laboratory School at Eastern.</p>\n<p>Today, the building houses the Departments of Earth Sciences, Geography and Planning, and the Dean’s Office for the College of Letters, Arts, and Social Sciences.</p></body></html>",
                            Name = "Roark Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4181,
                            Description = "<html><body><p>The Rowlett Building is a three-story, 53,000-square-foot facility housing the Department of Associate Degree Nursing, the Department of Baccalaureate and Graduate Nursing, and the Health Professions Learning Resource Center.</p>\n<p>Rowlett also houses a state-of-the-art simulation lab for all EKU allied health students to use and EKU’s Student Health Services Clinic.</p></body></html>",
                            Name = "Rowlett Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4183,
                            Description = "<html><body><p>The Stratton Building is home to EKU’s program of distinction, the College of Justice, Safety, and Military Science.</p>\n<p>The School of Justice Studies offers majors in criminal justice, police studies, social justice studies and more.</p>\n<p>Since 1972, the School of Safety, Security, and Emergency Management programs have been the first choice for students around the world.</p>\n<p>Offering students options in homeland security, occupational safety, and emergency management, we graduate some of the country’s most in-demand safety and security professionals.</p></body></html>",
                            Name = "Stratton Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4188,
                            Description = "<html><body><p>The University Building, also known as Old Central, is the oldest building on campus and is listed in the National Register of Historic Places.</p>\n<p>It now houses the offices and classrooms for the Department of History, the EKU Honors Program, and is part of the Library’s new addition.</p></body></html>",
                            Name = "University Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4189,
                            Description = "<html><body><p>The Wallace Building, located conveniently to Case Dining Hall, is home to EKU’s Math and Statistics Department, EKU’s communication disorders program, American Sign Language and interpretation programs, and English courses.</p>\n<p>Wallace houses two large lecture halls located on the ground floor, where students may have classes.</p></body></html>",
                            Name = "Wallace Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4192,
                            Description = "<html><body><p>The Whalin Technology Complex and the Central Kentucky Regional Airport are located just a few miles from campus.</p>\n<p>Whalin is a series of buildings that houses classrooms and labs for courses that are a part of the College of Science, Technology, Engineering, and Mathematics.</p>\n<p>As a student, you can pursue careers in high-demand fields like aviation, applied engineering management, construction management and more.</p>\n<p>Co-ops and internships, along with well-connected faculty, give our students a competitive edge.</p>\n<p>Our aviation program is one of the most affordable in the nation and is the only one of its kind in Kentucky.</p></body></html>",
                            Name = "Whalin Complex",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4109,
                            Description = "<html><body><p>The Alumni Coliseum, also known as the Paul S. McBrayer Arena, has been home to EKU Colonel basketball since the 1963-64 season and volleyball since 1991.</p>\n<p>Alumni Coliseum seats 6,500 fans for sporting events and around 8,000 individuals for events, including graduation ceremonies.</p></body></html>",
                            Name = "Alumni Coliseum",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4179,
                            Description = "<html><body><p>For half a century, Roy Kidd Stadium has been a cornerstone for Eastern Kentucky University and Colonel athletics.</p>\n<p>The stadium has been host to millions of fans, pivotal games and many campus activities.</p>\n<p>With recent improvements, Roy Kidd Stadium is now better served to meet the needs of EKU’s student-athletes, the university and the community.</p></body></html>",
                            Name = "Roy Kidd Stadium",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4144,
                            Description = "<html><body><p>The Carloftis Garden is located near the intersection of Lancaster and Park Drive and fronting new Martin Hall.</p>\n<p>The Carloftis Garden is the first on any public university campus to bear the stamp of Jon Carloftis, an internationally renowned landscape designer who grew up in Rockcastle County and became known as “Gardener to the Stars.”</p>\n<p>The Carloftis Garden is also home to the Divine Nine Plaza: a reminder to future generations of the important role that NPHC fraternities and sororities continue to play in shaping young lives.</p></body></html>",
                            Name = "Carloftis Gardens",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4184,
                            Description = "<html><body><p>Our brand-new Student Recreation Center provides students with everything they need to stay fit and have fun.</p>\n<p>Exercise and get involved in a variety of ways with three hardwood multi-purpose sports courts lined for basketball and volleyball; one multi-activity gym, lined for indoor soccer, hockey, handball, basketball or volleyball; three racquetball or wallyball courts; a cardio and fitness area and an elevated indoor track.</p>\n<p>There are also three group fitness studios where students can participate in yoga, HIIT, Zoomba and more.</p>\n<p>We even have our own indoor/outdoor climbing bouldering center, an aquatics center, and an esports lounge.</p>\n<p>Not to mention full locker rooms and sauna.</p>\n<p>Fun fact! All the games are free for EKU students, and most offer free t-shirts.</p></body></html>",
                            Name = "Student Recreation Center",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4187,
                            Description = "<html><body><p>Turner Gate is the main pedestrian entrance to the university and the beginning of a new student tradition.</p>\n<p>All entering freshmen pass through the gate during the Big E Welcome.</p>\n<p>Students pass the pillars of Wisdom and Knowledge, symbolizing everything they will gain from their Eastern experience.</p></body></html>",
                            Name = "Turner Gate",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4193,
                            Description = "<html><body><p>The Charles D. Whitlock Building houses all the student services you’ll need, from application to graduation.</p>\n<p>Whitlock is home to offices such as Admissions, Financial Aid &amp; Scholarships, Housing &amp; Residential Life, Student Outreach &amp; Transition, and many others.</p>\n<p>Whether you come to campus for your first visit or a special event, your day will begin in our Welcome Center.</p></body></html>",
                            Name = "Whitlock Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4165,
                            Description = "<html><body><p>Whether you prefer the relative quiet of a small town or the buzz of a bigger city, living in Richmond offers the best of both worlds.</p>\n<p>Richmond is a fast-growing yet quiet community where the Bluegrass region and its scenic horse farms meet the foothills of the rugged Appalachian Mountains.</p>\n<p>Just 25 miles North, an easy drive on I-75, is Kentucky’s second-largest city: Lexington.</p>\n<p>Other large cities within an easy two-hour drive are Louisville, Kentucky; Cincinnati, Ohio and Knoxville, Tennessee.</p></body></html>",
                            Name = "Main Street - Richmond, KY",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4139,
                            Description = "<html><body><p>Burnam Hall is located across the historic Ravine and close to the newly renovated Case Dining Hall and Powell Student Center.</p>\n<p>Burnam is a unique residence hall, offering many different housing styles for students, including spaces with traditional, enhanced traditional, and suite-style options.</p></body></html>",
                            Name = "Burnam Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4153,
                            Description = "<html><body><p>With a welcoming lounge and a beautiful outdoor patio, Clay Hall is a great place to live at EKU.</p>\n<p>Centrally located, Clay Hall is convenient to Case Dining Hall, Powell Student Center and the new Science Building.</p>\n<p>Clay Hall offers enhanced traditional spaces that house two residents with a sink in the room and a community bathroom.</p>\n<p>Enhanced traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>",
                            Name = "Clay Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4157,
                            Description = "<html><body><p>The Eastern Scholar House opened in the fall of 2017.</p>\n<p>It offers a transformative experience for single parents pursuing a college education.</p>\n<p>Located in the 800 area of Brockton, near the university’s Fitness and Wellness Center, the Scholar House is the product of a partnership between the Kentucky Housing Corporation (KHC), Kentucky River Foothills Development Council Inc. (KRFDC), the City of Richmond and EKU.</p>\n<p>The Scholar House is a one-stop shop of services for single parents, including access to an on-site childhood development facility, counseling services, life-skills workshops, and proximity to EKU’s Student Health Services and Women’s Clinic.</p></body></html>",
                            Name = "Eastern Scholar House",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4162,
                            Description = "<html><body><p>EKU Housing &amp; Residence Life offers apartment-style living for upperclassmen students, which includes the conveniences of campus life.</p>\n<p>Grand Campus is a 500+ room apartment complex, open to EKU juniors, seniors and graduate students.</p>\n<p>Grand Campus offers a beautiful on-campus location with many amenities that are not found in standard traditional Residence Halls.</p></body></html>",
                            Name = "Grand Campus Apartments",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4164,
                            Description = "<html><body><p>Located next to the EKU Center for the Arts, Keene Hall offers a convenient location to the Business &amp; Technology Center; the College of Justice, Safety &amp; Military Science and the Perkins Building.</p>\n<p>With affordable living, a close-knit community and large outdoor patio spaces (including a sand volleyball court), students develop close bonds and build strong relationships.</p>\n<p>Keene Hall offers traditional spaces housing two residents per room and offering a community bathroom.</p>\n<p>Traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>",
                            Name = "Keene Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4166,
                            Description = "<html><body><p>Martin Hall is home to more than 600 students and overlooks the beautiful Carloftis Gardens, designed by nationally acclaimed rooftop garden designer John Carloftis.</p>\n<p>Martin joins four other newly constructed residence halls, bringing the total number to 12.</p>\n<p>This allows more than 5,000 students the opportunity to live alongside their fellow Colonels on the Campus Beautiful.</p>\n<p>With a variety of amenities and all located within a 10-minute walk to most classes, you’re sure to find a perfect fit for you.</p></body></html>",
                            Name = "Martin Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4170,
                            Description = "<html><body><p>Nestled in the center of campus, McGregor Hall is an exciting place to live!</p>\n<p>McGregor is located in the center of campus, convenient to the Library, Powell Student Center, and Case Dining Hall.</p>\n<p>McGregor Hall offers double rooms which house two residents.</p>\n<p>The rooms are equipped with a sink and two built-in wardrobes.</p>\n<p>Convenient community bathrooms are located on each floor.</p></body></html>",
                            Name = "McGregor Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4175,
                            Description = "<html><body><p>Situated near the Science Buildings and adjacent to South Hall, North Hall is just steps away from Case Dining Hall and the Powell Student Center.</p>\n<p>North Hall offers simple suite spaces that house four residents between two bedrooms connected by a full bathroom.</p>\n<p>North Hall also offers two bedrooms shared by two students who each share a bathroom.</p>\n<p>The bedrooms are connected by a common living space and a kitchenette.</p></body></html>",
                            Name = "North Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4176,
                            Description = "<html><body><p>Palmer Hall is the perfect community for students who want a central campus location!</p>\n<p>Located directly next to the brand-new campus recreation center and just steps from the Powell Student Center and Case Dining Hall, Palmer Hall is a perfect location to enjoy campus conveniences.</p>\n<p>Palmer Hall offers traditional spaces which house two residents per room and offer a community bathroom.</p>\n<p>Traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>",
                            Name = "Palmer Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4182,
                            Description = "<html><body><p>South Hall is conveniently located on Kit Carson Drive between the Science Building and North Hall.</p>\n<p>South Hall serves as a break hall, staying open during all breaks throughout the fall, winter and spring months.</p>\n<p>South Hall offers two floor-plan options: two bedrooms with access to a small living room/kitchenette area and shared bathroom, and four bedrooms with access to a small living room/kitchenette area and shared bathroom.</p></body></html>",
                            Name = "South Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4185,
                            Description = "<html><body><p>Sullivan Hall is known for its warm and welcoming front porch.</p>\n<p>With a beautiful view of the historic Ravine and centrally located within walking distance to Case Dining Hall, Powell Student Center and the Crabbe Library, Sullivan Hall is perfect for students who want to be in the middle of the action at EKU.</p>\n<p>Sullivan Hall offers larger than normal traditional spaces, which house two residents per room and offers a community bathroom.</p>\n<p>Traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>",
                            Name = "Sullivan Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4186,
                            Description = "<html><body><p>With convenient parking and a location that overlooks the Campus Beautiful, Telford Hall is a desired community for students who want suite-style living within a close-knit community.</p>\n<p>Telford offers traditional suite spaces where four residents share two bedrooms and a full bathroom, which connect the suite.</p></body></html>",
                            Name = "Telford Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4190,
                            Description = "<html><body><p>Also known as the Ski Lodge, Walters Hall has a warm and inviting interior lobby with plenty of space for socializing, hall programs and studying.</p>\n<p>Conveniently located next to EKU's Caffeinated Colonel Coffee Shop, Walters Hall is just a short walk to Case Dining Hall, the historic Ravine and Crabbe Library.</p>\n<p>Walters Hall offers enhanced traditional spaces which house two residents including a sink in the room and a community bathroom.</p>\n<p>Enhanced traditional spaces offer affordable living in a close-knit community where students get involved and easily engage with others.</p></body></html>",
                            Name = "Walters Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4146,
                            Description = "<html><body><p>Case Dining Hall houses the brand-new Case Kitchen located on the second floor.</p>\n<p>Case Kitchen features full access breakfast, lunch or dinner with international entrees, a grill, deli, salad bar and more.</p>\n<p>Case Food Court just downstairs, is a place to meet, greet and eat between classes.</p>\n<p>Students can dine in or take out various options: Chick-fil-A, Subway, Moe’s Southwest Grill, Panda Express and a convenient POD Market to quickly grab some things and take them back to your residence hall.</p></body></html>",
                            Name = "Case Dining Hall",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4147,
                            Description = "<html><body><p>The EKU Center for the Arts is Central Kentucky's premier live entertainment and arts destination, located conveniently off I-75 in Richmond.</p>\n<p>The Center for the Arts is home to premier artistic productions, community outreach opportunities and educational programming.</p></body></html>",
                            Name = "Center for the Arts",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4177,
                            Description = "<html><body><p>Our Powell Student Center is home to various resources, including Student Life &amp; First-Year Experience, the Center for Inclusive Excellence and Global Engagement (CIEGE), and our very own Vets|Ready Center for our military and veteran students.</p>\n<p>This facility also hosts a U.S. Bank, Starbucks, spacious lounge study spaces and more.</p></body></html>",
                            Name = "Powell Student Center",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4178,
                            Description = "<html><body><p>We are now at an iconic EKU space, the Ravine.</p>\n<p>This outdoor earth-carved arena is considered the heart and soul of campus.</p>\n<p>Constructed in the 1920s, the Ravine is used for plays, concerts, classes, and Rec the Ravine, an annual event hosted by Campus Recreation.</p>\n<p>As you can see, this space is loved by all students and used as a great relaxation space.</p>\n<p>It's just another reason we are called the Campus Beautiful.</p></body></html>",
                            Name = "Ravine",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4191,
                            Description = "<html><body><p>The Weaver Health Building, located conveniently across from the Whitlock Building, is primarily occupied by EKU ROTC and the exercise and sport science program.</p>\n<p>There is an in-ground swimming pool in the basement of the Weaver Building and dance studios, a gymnasium and the Faculty Fitness and Wellness Center.</p></body></html>",
                            Name = "Weaver Building",
                            rating = 1.0
                        },
                        new
                        {
                            ID = 4163,
                            Description = "<html><body><p>Located in the heart of EKU’s Richmond Campus, the Keen Johnson Building plays host to numerous kinds of events.</p>\n<p>The Ballroom and Walnut Hall are the perfect size for large social gatherings, while the East, South and West halls on the second floor are great for smaller conferences and meetings.</p>\n<p>There is even a small performance space, the Pearl Buchanan Theater, available for small on-campus groups.</p>\n<p>Keen Johnson is also located near EKU’s Daniel Boone statue.</p>\n<p>Daniel Boone’s golden toe is said to give students, faculty and staff good luck.</p></body></html>",
                            Name = "Keen Johnson Building",
                            rating = 1.0
                        });
                });

            modelBuilder.Entity("CSC308.CBR.DataObjects.DbMatch", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("BlueTeamID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("BlueTeamLocationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RedTeamID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("RedTeamLocationID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BlueTeamLocationID");

                    b.HasIndex("RedTeamLocationID");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("CSC308.CBR.DataObjects.DbMatch", b =>
                {
                    b.HasOne("CSC308.CBR.DataObjects.DbLocation", "BlueTeamLocation")
                        .WithMany()
                        .HasForeignKey("BlueTeamLocationID");

                    b.HasOne("CSC308.CBR.DataObjects.DbLocation", "RedTeamLocation")
                        .WithMany()
                        .HasForeignKey("RedTeamLocationID");

                    b.Navigation("BlueTeamLocation");

                    b.Navigation("RedTeamLocation");
                });
#pragma warning restore 612, 618
        }
    }
}
