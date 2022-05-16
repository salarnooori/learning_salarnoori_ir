<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="UIL.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="UTF-8" />
    <title>بخش آموزشی</title>

    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=yes" />
    <meta http-equiv="Content-Type" content="text/html; charset=GB2312" />
    <meta name="Generator" content="Salar Noori" />
    <meta name="Author" content="Salar Noori" />
    <meta name="Keywords" content="Salar" />
    <meta name="Description" content="Salar" />


    <link rel="icon" type="image/x-icon" href="assets/img/favicon.png" />


    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"
        integrity="sha512-9usAa10IRO0HhonpyAIVpjrylPvoDwiPUiKdWk5t3PyolY1cOd4DSE0Ga+ri4AuTroPR5aQvXU9xC6qOPnzFeg=="
        crossorigin="anonymous" referrerpolicy="no-referrer" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous" />

    <style>
    </style>

    <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="css/bgStyle.css" />
</head>
<body dir="rtl" class="text-white">

    <form id="form1" runat="server">
        <div>


            <div style="position: relative; top: 0px; left: 0px; width: 100%; height: 100%; z-index: 1;">
                
                <!-- main header -->
                <div class="bg-dark pt-3" style="z-index: 10001;">
                    <div class="container py-3">
                        <div class="row">
                            <div class="col-lg-3 col-md-4 col-sm-5 text-center text-whiteg">
                                <h2>سالار نوری - آموزش</h2>
                            </div>
                            <div class="col-lg-3 col-md-1 d-none d-md-block">
                            </div>
                            <div class="col-lg-4 col-md-3 col-sm-1 d-none d-sm-block">
                                <div class="text-center">
                                    <span>
                                        <input type="text" placeholder="جستجو کنید..."></span>
                                    <span><a class="btn btn-primary" href="#"><i class="fas fa-search"></i></a></span>
                                </div>
                            </div>
                            <div
                                class="col-lg-2 col-md-4 col-sm-5 d-flex justify-content-md-end justify-content-center text-sm-center">
                                <a class="btn btn-success " href="/Admin/Management.aspx">ورود / ثبت نام</a>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- nav bar -->
                <nav class="navbar navbar-expand-lg navbar-light myfade nav-tabs sticky-top" style="z-index:10001;">
            <div class="container-fluid justify-content-start">
                <a class="navbar-brand" href="#"></a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse"
                    data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false"
                    aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNavDropdown">
                    <ul class="navbar-nav">
                        <li class="nav-item shadow">
                            <a class="nav-link active" aria-current="page" href="#">صفحه اصلی</a>
                        </li>
                        <li class="nav-item shadow dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown1" role="button"
                                data-bs-toggle="dropdown" aria-expanded="false">
                                برنامه نویسی
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown1">
                                <li><a class="dropdown-item" href="#">C#</a></li>
                                <li><a class="dropdown-item" href="#">C++</a></li>
                                <li><a class="dropdown-item" href="#">HTML</a></li>
                                <li><a class="dropdown-item" href="#">CSS</a></li>
                                <li><a class="dropdown-item" href="#">JavaScript</a></li>
                                <li><a class="dropdown-item" href="#">Python</a></li>
                            </ul>
                        </li>
                        <li class="nav-item shadow dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown2" role="button"
                                data-bs-toggle="dropdown" aria-expanded="false">
                                بازی سازی
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown2">
                                <li><a class="dropdown-item" href="#">Unity</a></li>
                                <li><a class="dropdown-item" href="#">AI</a></li>
                                <li><a class="dropdown-item" href="#">Particle System</a></li>
                                <li><a class="dropdown-item" href="#">Physic</a></li>
                                <li><a class="dropdown-item" href="#">Lithing</a></li>
                                <li><a class="dropdown-item" href="#">Network</a></li>
                                <li><a class="dropdown-item" href="#">Shooter</a></li>
                                <li><a class="dropdown-item" href="#">Shader</a></li>
                                <li><a class="dropdown-item" href="#">AR</a></li>
                                <li><a class="dropdown-item" href="#">VR</a></li>
                            </ul>
                        </li>
                        <li class="nav-item shadow dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown2" role="button"
                                data-bs-toggle="dropdown" aria-expanded="false">
                                مدل سازی
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown2">
                                <li><a class="dropdown-item" href="#">Blender</a></li>
                                <li><a class="dropdown-item" href="#">Maya</a></li>
                                <li><a class="dropdown-item" href="#">Speed Tree</a></li>
                                <li><a class="dropdown-item" href="#">Topology</a></li>
                                <li><a class="dropdown-item" href="#">Physic</a></li>
                                <li><a class="dropdown-item" href="#">Rig</a></li>
                                <li><a class="dropdown-item" href="#">Animate</a></li>
                                <li><a class="dropdown-item" href="#">Render</a></li>
                            </ul>
                        </li>
                        <li class="nav-item shadow dropdown">
                            <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown2" role="button"
                                data-bs-toggle="dropdown" aria-expanded="false">
                                گرافیک
                            </a>
                            <ul class="dropdown-menu" aria-labelledby="navbarDropdown2">
                                <li><a class="dropdown-item" href="#">Photoshop</a></li>
                                <li><a class="dropdown-item" href="#">Adobe XD</a></li>
                                <li><a class="dropdown-item" href="#">Typogrphy</a></li>
                                <li><a class="dropdown-item" href="#">Logo</a></li>
                                <li><a class="dropdown-item" href="#">3d Paint</a></li>
                                <li><a class="dropdown-item" href="#">Texturing</a></li>
                                <li><a class="dropdown-item" href="#">Quixel Megascans</a></li>
                                <li><a class="dropdown-item" href="#">Substance Designer</a></li>
                                <li><a class="dropdown-item" href="#">Substance Painter</a></li>
                            </ul>
                        </li>
                        <li class="nav-item shadow">
                            <a class="nav-link" href="#">درخواست آموزش</a>
                        </li>
                    </ul>
                </div>
            </div>

        </nav>

        <hr />

                <main>

                    <!-- new tutorials carousel -->
                    <div class="container">
                        <div class="MyContainer p-0 m-0" style="direction: ltr;">
                            <div class="slider" style="transform: translateX(-80%);">
                                <% 
                                    int i = 1;
                                    foreach (Entity.Post p in carusel_posts)
                                    { %>

                                        <div class="box<%=i%> box">
                                            <div class="bg" style="opacity: 1; transform: translate(0%, 0px) skew(7.00031deg, 0deg);">
                                            </div>
                                            <div class="details">
                                                <h2 style="transform: translate(0px, 0px); opacity: 1;"><%=p.subject%></h2>
                                                <p style="opacity: 1; width: 300px; display: -webkit-box; -webkit-line-clamp: 3; -webkit-box-orient: vertical; overflow: hidden; text-overflow: ellipsis;">
                                                    <%=p.summery%>
                                                </p>
                                                <br />
                                                <h6><%=p.modifydate%> : تاریخ</h6>
                                                <button style="transform: translate(0px, 0px); opacity: 1;">ورود</button>
                                            </div>

                                            <div class="illustration">
                                                <div class="inner"></div>
                                            </div>
                                        </div>

                                <% 
                                        i++;
                                    } %>
                            </div>

                            <svg xmlns="http://www.w3.org/2000/svg" class="prev" width="56.898" height="91"
                                viewBox="0 0 56.898 91">
                                <path d="M45.5,0,91,56.9,48.452,24.068,0,56.9Z" transform="translate(0 91) rotate(-90)"
                                    fill="#fff">
                                </path>
                            </svg>
                            <svg xmlns="http://www.w3.org/2000/svg" class="next" width="56.898" height="91"
                                viewBox="0 0 56.898 91">
                                <path d="M45.5,0,91,56.9,48.452,24.068,0,56.9Z" transform="translate(56.898) rotate(90)"
                                    fill="#fff">
                                </path>
                            </svg>
                            <div class="trail">
                                <div class="box1">1</div>
                                <div class="box2">2</div>
                                <div class="box3">3</div>
                                <div class="box4">4</div>
                                <div class="box5 active">5</div>
                            </div>
                        </div>
                    </div>

                    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.3.2/gsap.min.js"></script>
                    <script src="https://cdnjs.cloudflare.com/ajax/libs/gsap/3.3.2/CSSRulePlugin.min.js"></script>
                    <script src="js/slider.js"></script>


                    <!-- some text -->
                    <br />
                    <br />
                    <div class="container">
                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci reiciendis consequuntur recusandae
                    quod,
                    similique consequatur quae! Reiciendis quae, enim, nesciunt quo cum, commodi at nemo libero
                    consequuntur
                    non
                    dicta nostrum.
                        </p>

                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci reiciendis consequuntur recusandae
                    quod,
                    similique consequatur quae! Reiciendis quae, enim, nesciunt quo cum, commodi at nemo libero
                    consequuntur
                    non
                    dicta nostrum.
                        </p>
                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci reiciendis consequuntur recusandae
                    quod,
                    similique consequatur quae! Reiciendis quae, enim, nesciunt quo cum, commodi at nemo libero
                    consequuntur
                    non
                    dicta nostrum.
                        </p>
                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci reiciendis consequuntur recusandae
                    quod,
                    similique consequatur quae! Reiciendis quae, enim, nesciunt quo cum, commodi at nemo libero
                    consequuntur
                    non
                    dicta nostrum.
                        </p>
                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Adipisci reiciendis consequuntur recusandae
                    quod,
                    similique consequatur quae! Reiciendis quae, enim, nesciunt quo cum, commodi at nemo libero
                    consequuntur
                    non
                    dicta nostrum.
                        </p>
                    </div>
                    <br />
                    <br />

                    <!-- categories -->
                    <div class="container">
                        <div class="row">
                            <br />
                            <br />
                            <h3>دسته های آموزشی</h3>
                            <br />
                            <br />
                            <div class="container col-lg-3 col-md-6 col-sm-12">
                                <a class="my-2 card" href="#">
                                    <div class="card-body">
                                        <img class="card-img" width="300" height="300" src="assets/img/cat-graphic.jpg">
                                    </div>
                                    <div class="card-footer text-center">
                                        <span>طراحی</span>
                                    </div>
                                </a>
                            </div>
                            <div class="container col-lg-3 col-md-6 col-sm-12">
                                <a class="my-2 card" href="#">
                                    <div class="card-body">
                                        <img class="card-img" width="300" height="300" src="assets/img/cat-programming.jpg">
                                    </div>
                                    <div class="card-footer text-center">
                                        <span>برنامه نویسی</span>
                                    </div>
                                </a>
                            </div>
                            <div class="container col-lg-3 col-md-6 col-sm-12">
                                <a class="my-2 card" href="#">
                                    <div class="card-body">
                                        <img class="card-img" width="300" height="300" src="assets/img/cat-gamedev.jpg">
                                    </div>
                                    <div class="card-footer text-center">
                                        <span>بازی سازی</span>
                                    </div>
                                </a>
                            </div>
                            <div class="container col-lg-3 col-md-6 col-sm-12">
                                <a class="my-2 card" href="#">
                                    <div class="card-body">
                                        <img class="card-img" width="300" height="300" src="assets/img/cat-modelling.jpg">
                                    </div>
                                    <div class="card-footer text-center">
                                        <span>مدل سازی</span>
                                    </div>
                                </a>
                            </div>

                        </div>
                    </div>

                    <br />
                    <br />

                    <!-- tutorials -->
                    <div class="container">
                        <nav>
                            <div class="d-flex justify-content-between mb-2">

                                <h3 class="h5 swiper-title">آموزش‌های پرمخاطب</h3>
                                <br />
                                <br />
                            </div>

                            <div class="nav nav-tabs" id="nav-tab" role="tablist">
                                <button class="nav-link active" id="nav-1-tab" data-bs-toggle="tab" data-bs-target="#nav-1"
                                    type="button" role="tab" aria-controls="nav-1" aria-selected="true">
                                    همه</button>
                                <button class="nav-link" id="nav-2-tab" data-bs-toggle="tab" data-bs-target="#nav-2"
                                    type="button" role="tab" aria-controls="nav-2" aria-selected="false">
                                    برنامه نویسی</button>
                                <button class="nav-link" id="nav-3-tab" data-bs-toggle="tab" data-bs-target="#nav-3"
                                    type="button" role="tab" aria-controls="nav-3" aria-selected="false">
                                    طراحی</button>
                                <button class="nav-link" id="nav-4-tab" data-bs-toggle="tab" data-bs-target="#nav-4"
                                    type="button" role="tab" aria-controls="nav-4" aria-selected="false">
                                    بازی سازی</button>
                                <button class="nav-link" id="nav-5-tab" data-bs-toggle="tab" data-bs-target="#nav-5"
                                    type="button" role="tab" aria-controls="nav-5" aria-selected="false">
                                    مدل سازی</button>


                            </div>
                        </nav>
                        <div class="tab-content" id="nav-tabContent">
                            <div class="tab-pane show active" id="nav-1" role="tabpanel" aria-labelledby="nav-1-tab">
                                <div class="row">
                                    <% foreach (Entity.Post p in all_posts)
                                        { %>

                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#">
                                            <img src="<%=ResolveUrl("~\\assets\\uploads\\posts\\"+p.image) %>""
                                                loading="lazy" alt="آموزش" class="" />
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    <h3><%=p.subject %></h3>
                                                    <hr />
                                                    <p style="display: -webkit-box; -webkit-line-clamp: 5; -webkit-box-orient: vertical; overflow: hidden; text-overflow: ellipsis;"><%=p.summery %></p>
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                <%=p.modifydate %>
                                            </div>
                                        </a>



                                    </div>

                                    <% } %>
                                </div>
                            </div>
                            <div class="tab-pane" id="nav-2" role="tabpanel" aria-labelledby="nav-2-tab">
                                <div class="row">
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                </div>

                            </div>
                            <div class="tab-pane" id="nav-3" role="tabpanel" aria-labelledby="nav-3-tab">
                                <div class="row">
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                </div>
                            </div>
                            <div class="tab-pane" id="nav-4" role="tabpanel" aria-labelledby="nav-4-tab">
                                <div class="row">
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>

                                </div>
                            </div>
                            <div class="tab-pane" id="nav-5" role="tabpanel" aria-labelledby="nav-5-tab">
                                <div class="row">
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                    <div class="col-lg-3 col-md-6 col-sm-12 course-card my-3 grid-item upcoming_style treasure treasure-color swiper-slide swiper-slide-active"
                                        role="group">


                                        <a rel="noopener noreferrer" class="card h-100 position-relative" href="#"
                                            data-ga-course-title="SKU: fvpht9808">
                                            <img src="https://img.freepik.com/free-vector/avatar-man-learning-online_24640-59160.jpg"
                                                loading="lazy" alt="آموزش فلان" class="">
                                            <div class="card-body card-title" style="width: 100%; overflow: hidden;">
                                                <div class="show-text-card">
                                                    آموزش فلان
                                                </div>
                                            </div>
                                            <div class="card-footer d-flex justify-content-between w-auto show-footer-card "
                                                style="font-size: 0.95rem">
                                                ۱۱۰,۰۰۰ تومان
                                            </div>
                                        </a>



                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                    <br />
                    <br />
                </main>

                <hr>

                <footer>
                    <div>

                        <!-- footer -->
                        <div class="myfade">
                            <br />
                            <div class="container my-5">
                                <div class="row">
                                    <div class="col-md-4 col-sm-12">
                                        <div class="container">
                                            <h5>وب سایت آموزشی سالار نوری</h5>
                                            <hr>
                                            <p>
                                                این سایت با هدف ایجاد مرجعی بسیار عالی برای علاقمندان به یادگیری ساخته شد، تا در
                                        یک فضایی بسیار منحصر به فرد شما بتوانید بهترین پکیج ها و دورهای آموزشی ایران را
                                        تهیه نمایید.
                                            </p>
                                        </div>
                                    </div>
                                    <div class="col-md-4 col-sm-12">
                                        <h5 class="text-center">دسترسی سریع</h5>
                                        <hr>
                                        <ul style="list-style-type: none; text-align: right;">
                                            <li>
                                                <a href="#/">برنامه ‌نویسی
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#/">گرافیک
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#/">بازی سازی
                                                </a>
                                            </li>
                                            <li>
                                                <a href="#/">مدل سازی
                                                </a>
                                            </li>
                                        </ul>
                                    </div>
                                    <div class="col-md-4 col-sm-12">
                                        <h5>مشترک شدن</h5>
                                        <hr>
                                        <span>
                                            <input type="email" placeholder="ایمیل خود را وارد کنید"></span>
                                        <span><a href="#" class="btn btn-info">اشتراک</a></span>
                                    </div>
                                </div>
                            </div>
                            <br />
                        </div>

                        <!-- social networks -->
                        <div class="network bg-dark">
                            <div class="py-2 d-flex justify-content-center">
                                <ul class="list-unstyled list-inline text-center mb-0">
                                    <li class="list-inline-item">
                                        <a href="#">
                                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="36px"
                                                height="36px">
                                                <path fill="#fff"
                                                    d="M20,4H4C2.895,4,2,4.895,2,6v12c0,1.105,0.895,2,2,2h16c1.105,0,2-0.895,2-2V6C22,4.895,21.105,4,20,4z M19.601,8.249 l-7.071,4.42c-0.324,0.203-0.736,0.203-1.06,0l-7.071-4.42C4.151,8.094,4,7.822,4,7.53v0c0-0.666,0.733-1.072,1.297-0.719L12,11 l6.703-4.189C19.267,6.458,20,6.864,20,7.53v0C20,7.822,19.849,8.094,19.601,8.249z">
                                                </path>
                                            </svg>
                                        </a>
                                    </li>
                                    <li class="list-inline-item" id="twitter">
                                        <a rel="noopener noreferrer" href="#" target="_blank">
                                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="36px"
                                                height="36px">
                                                <path fill="#fff"
                                                    d="M17,3H7C4.791,3,3,4.791,3,7v10c0,2.209,1.791,4,4,4h10c2.209,0,4-1.791,4-4V7C21,4.791,19.209,3,17,3z M17.05,9.514 c0,0.086,0,0.171,0,0.343c0,3.257-2.486,7.029-7.029,7.029c-1.371,0-2.657-0.429-3.771-1.114c0.171,0,0.429,0,0.6,0 c1.114,0,2.229-0.429,3.086-1.029c-1.114,0-1.971-0.771-2.314-1.714c0.171,0,0.343,0.086,0.429,0.086c0.257,0,0.429,0,0.686-0.086 c-1.114-0.257-1.971-1.2-1.971-2.4c0.343,0.171,0.686,0.257,1.114,0.343c-0.686-0.6-1.114-1.286-1.114-2.143 c0-0.429,0.086-0.857,0.343-1.2c1.2,1.457,3,2.486,5.057,2.571c0-0.171-0.086-0.343-0.086-0.6c0-1.371,1.114-2.486,2.486-2.486 c0.686,0,1.371,0.257,1.8,0.771c0.6-0.086,1.114-0.343,1.543-0.6c-0.171,0.6-0.6,1.029-1.114,1.371 c0.514-0.086,0.943-0.171,1.457-0.429C17.907,8.743,17.479,9.171,17.05,9.514z">
                                                </path>
                                            </svg>
                                        </a>
                                    </li>
                                    <li class="list-inline-item" id="facebook">
                                        <a rel="noopener noreferrer" href="#" target="_blank">
                                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="36px"
                                                height="36px">
                                                <path fill="#fff"
                                                    d="M17,3H7C4.791,3,3,4.791,3,7v10c0,2.209,1.791,4,4,4h5.621v-6.961h-2.343v-2.725h2.343V9.309 c0-2.324,1.421-3.591,3.495-3.591c0.699-0.002,1.397,0.034,2.092,0.105v2.43h-1.428c-1.13,0-1.35,0.534-1.35,1.322v1.735h2.7 l-0.351,2.725h-2.365V21H17c2.209,0,4-1.791,4-4V7C21,4.791,19.209,3,17,3z">
                                                </path>
                                            </svg>
                                        </a>
                                    </li>
                                    <li class="list-inline-item" id="youtube">
                                        <a rel="noopener noreferrer" href="#" target="_blank">
                                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="36px"
                                                height="36px">
                                                <path fill="#fff"
                                                    d="M21.582,6.186c-0.23-0.86-0.908-1.538-1.768-1.768C18.254,4,12,4,12,4S5.746,4,4.186,4.418 c-0.86,0.23-1.538,0.908-1.768,1.768C2,7.746,2,12,2,12s0,4.254,0.418,5.814c0.23,0.86,0.908,1.538,1.768,1.768 C5.746,20,12,20,12,20s6.254,0,7.814-0.418c0.861-0.23,1.538-0.908,1.768-1.768C22,16.254,22,12,22,12S22,7.746,21.582,6.186z M10,14.598V9.402c0-0.385,0.417-0.625,0.75-0.433l4.5,2.598c0.333,0.192,0.333,0.674,0,0.866l-4.5,2.598 C10.417,15.224,10,14.983,10,14.598z">
                                                </path>
                                            </svg>
                                        </a>
                                    </li>
                                    <li class="list-inline-item" id="instagram">
                                        <a rel="noopener noreferrer" href="#" target="_blank">
                                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="36px"
                                                height="36px">
                                                <path fill="#fff"
                                                    d="M 8 3 C 5.239 3 3 5.239 3 8 L 3 16 C 3 18.761 5.239 21 8 21 L 16 21 C 18.761 21 21 18.761 21 16 L 21 8 C 21 5.239 18.761 3 16 3 L 8 3 z M 18 5 C 18.552 5 19 5.448 19 6 C 19 6.552 18.552 7 18 7 C 17.448 7 17 6.552 17 6 C 17 5.448 17.448 5 18 5 z M 12 7 C 14.761 7 17 9.239 17 12 C 17 14.761 14.761 17 12 17 C 9.239 17 7 14.761 7 12 C 7 9.239 9.239 7 12 7 z M 12 9 A 3 3 0 0 0 9 12 A 3 3 0 0 0 12 15 A 3 3 0 0 0 15 12 A 3 3 0 0 0 12 9 z">
                                                </path>
                                            </svg>
                                        </a>
                                    </li>
                                    <li class="list-inline-item" id="telegram">
                                        <a rel="noopener noreferrer" href="#" target="_blank">
                                            <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="36px"
                                                height="36px">
                                                <path fill="#fff"
                                                    d="M 20.302734 2.984375 C 20.013769 2.996945 19.748583 3.080055 19.515625 3.171875 C 19.300407 3.256634 18.52754 3.5814726 17.296875 4.0976562 C 16.06621 4.61384 14.435476 5.2982348 12.697266 6.0292969 C 9.2208449 7.4914211 5.314238 9.1361259 3.3125 9.9785156 C 3.243759 10.007156 2.9645852 10.092621 2.65625 10.328125 C 2.3471996 10.564176 2.0039062 11.076462 2.0039062 11.636719 C 2.0039062 12.088671 2.2295201 12.548966 2.5019531 12.8125 C 2.7743861 13.076034 3.0504903 13.199244 3.28125 13.291016 C 3.9563403 13.559857 6.0424892 14.392968 6.9492188 14.755859 C 7.2668647 15.707799 8.0129251 17.950071 8.1875 18.501953 L 8.1855469 18.501953 C 8.3275588 18.951162 8.4659791 19.243913 8.6582031 19.488281 C 8.7543151 19.610465 8.8690398 19.721184 9.0097656 19.808594 C 9.0637596 19.842134 9.1235454 19.868148 9.1835938 19.892578 C 9.191962 19.896131 9.2005867 19.897012 9.2089844 19.900391 L 9.1855469 19.894531 C 9.2029579 19.901531 9.2185841 19.911859 9.2363281 19.917969 C 9.2652427 19.927926 9.2852873 19.927599 9.3242188 19.935547 C 9.4612233 19.977694 9.5979794 20.005859 9.7246094 20.005859 C 10.26822 20.005859 10.601562 19.710938 10.601562 19.710938 L 10.623047 19.695312 L 12.970703 17.708984 L 15.845703 20.367188 C 15.897113 20.439837 16.308174 20.998047 17.261719 20.998047 C 17.829844 20.998047 18.280978 20.718791 18.568359 20.423828 C 18.855741 20.128866 19.034757 19.82706 19.115234 19.417969 L 19.115234 19.414062 L 19.115234 19.412109 C 19.171124 19.121728 21.931641 5.265625 21.931641 5.265625 L 21.925781 5.2890625 C 22.01148 4.9067181 22.036735 4.5369631 21.935547 4.1601562 C 21.834358 3.7833495 21.561271 3.4156252 21.232422 3.2226562 C 20.903572 3.0296874 20.591699 2.9718046 20.302734 2.984375 z M 19.908203 5.1738281 C 19.799749 5.7182284 17.343164 18.059965 17.183594 18.878906 L 14.328125 16.240234 C 13.59209 15.559749 12.44438 15.535812 11.679688 16.181641 L 10.222656 17.414062 L 11 14.375 C 11 14.375 16.362547 8.9468594 16.685547 8.6308594 C 16.945547 8.3778594 17 8.2891719 17 8.2011719 C 17 8.0841719 16.939781 8 16.800781 8 C 16.675781 8 16.506016 8.1197812 16.416016 8.1757812 C 15.267511 8.8918132 10.350132 11.694224 7.96875 13.048828 C 7.8792978 12.995267 7.7913128 12.939666 7.6933594 12.900391 C 6.9119785 12.587666 5.4101276 11.985551 4.53125 11.634766 C 6.6055146 10.76177 10.161156 9.2658083 13.472656 7.8730469 C 15.210571 7.142109 16.840822 6.4570977 18.070312 5.9414062 C 19.108158 5.5060977 19.649538 5.2807035 19.908203 5.1738281 z M 17.152344 19.023438 C 17.152344 19.023438 17.154297 19.023438 17.154297 19.023438 C 17.154234 19.023761 17.152444 19.03095 17.152344 19.03125 C 17.154024 19.022709 17.151187 19.029588 17.152344 19.023438 z">
                                                </path>
                                            </svg>
                                        </a>
                                    </li>
                                </ul>
                                <div></div>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>

            <canvas id="projector" style="position: fixed;">Your browser does not support the Canvas
        element.</canvas>



            <script src="js/easeljs-0.7.1.min.js"></script>
            <script src="js/TweenMax.min.js"></script>
            <script src="js/background.js"></script>

            <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
                integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"
                crossorigin="anonymous"></script>

        </div>
    </form>
</body>
</html>
