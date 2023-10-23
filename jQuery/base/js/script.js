$(function () {
  // jQuery goes here...

  // Uncomment this line to fade out the red box on page load
  // $(".red-box").fadeOut(2000);
  // $(".green-box").fadeOut(2000);
  // $(".green-box").fadeOut(5000);
  // $(".green-box").fadeOut("slow");
  // $(".green-box").fadeOut("fast");
  // $(".red-box").fadeIn(1000);

  // $(".red-box").fadeTo(1000,0.5);
  // $(".green-box").fadeOut(1000);
  // $(".green-box").fadeTo(2000,0.3);
  // $(".green-box").fadeOut(1000);

  // $(".green-box").fadeIn(1000);


  // $(".red-box").fadeTo(2000,0.3);
  // $(".green-box").fadeTo(2000,0.5);
  // $(".blue-box").fadeTo(2000,0.8);


  // $(".green-box").fadeTo(1000,0.5);
  // $(".green-box").fadeToggle(2000);
  // $(".green-box").fadeToggle(2000);
  // // $(".green-box").fadeToggle("slow");


  // // $(".green-box").hide();
  // // $(".green-box").show();
  // $(".green-box").toggle(1000);
  // $(".green-box").toggle(1000);


  // $(".green-box").slideUp(1000);
  // $(".green-box").slideDown(1000);

  // $(".green-box").slideToggle(1000);

  // $(".green-box").animate({"margin-left":"+=500px"});
  // $(".green-box").animate({"margin-left":"+=500px"},1000);
  // $(".green-box").animate({"margin-left":"+=500px"},1000,"linear");
  // $(".green-box").animate({"margin-left":"+=100px"},1000,"linear",function () {
  //   alert("Green Animation Completed!");
  // });
  // $(".blue-box").animate({"margin-left":"+=100px"},1000,"linear",function () {
  //   // prompt("Blue Animation Completed!");
  //   alert("Blue Animation Completed!");
  // });


  // $(".green-box").animate({
  //   "margin-left": "+=200px",
  //   height: "50px",
  //   width: "50px",
  //   marginTop: "25px",
  //   opacity: "0"

  // }, 1000, "linear");

  // $("p").animate({
  //   "font-size" : "20px",
  //   // color : "red"
  // },2000);


  // var dTime = 1000;
  // var count=1;
  // $(".red-box").fadeTo(1000,0.3);
  // $(".green-box").delay(dTime*count).fadeTo(2000,0.5);
  // count++;
  // // $(".blue-box").delay(dTime*count).fadeTo(2000,0.7);
  // $(".blue-box").delay(2000).fadeTo(1000, 0.5).fadeTo(1000, 1.0).delay(1000).fadeOut();
  // console.log(count);

  // $(".red-box").fadeTo(2000,0.3);
  // $(".green-box").delay(1000).fadeTo(2000,0.5);
  // $(".blue-box").delay(2000).fadeTo(2000,0.7);



  // $(".lightbox").delay(500).fadeIn(1000);

  // $("li:even").css("background-color", "rgba(180, 180, 30, 0.8)");
  // $("li:eq(4)").css("background-color", "rgba(180, 180, 30, 0.8)");
  // $("li:nth-child(2)").css("background-color", "rgba(180, 180, 30, 0.8)");

  // var selected = $("input:checked");
  // console.log(selected.val());
  // var emails = $("input[type='email']");
  // highlight(emails);

  // var items = $("#list").find("li");
  // var items = $("#list").children("li");
  // var items = $("#list").parents();
  // var items = $("#list").parents("div");
  // var items = $("#list").parents("body");
  // var items = $("#list").parent();
  // var items = $("#list").siblings();
  // var items = $("#list").siblings(":header");
  // var items = $("#list").siblings("p");
  // var items = $("#list").prev();
  // var items = $("#list").next();
  // var items = $(":header").next();
  // // console.log(items);
  // highlight(items);
  // // var items1 = $("input[type='password']");
  // var items1 = $("input:password");
  // highlight(items1);

  // var everySecondItem = $("#list").children("li").filter(":even");
  // // var everySecondItem = $("#list").children("li").not(":odd");
  // highlight(everySecondItem);
  // var everyThirdItem = $("li li").filter(function (index) {
  //   return index % 3 == 0;
  // });
  // highlight(everyThirdItem);

  // var first = $("li").first();
  // // var first = $("li").last();
  // highlight(first);

  // var fifth = $("li").eq(4);
  // highlight(fifth);

  // var secondLast = $("li").eq(-2);
  // highlight(secondLast);

  // var notFun = $("li").not(function (index) {
  //   return index % 3 == 2;
  // });
  // highlight(notFun);

  // function highlight(element) {

  //   element.css("background-color", "rgba(180, 180, 30, 0.8)" );
  // }


  //*********  DOM-I  *********

  // $("ul ul:first").append("<li>Item-3 Added</li>");

  // $("<li> Item-4 Added</li>").appendTo($("ul ul:first"));
  // $("<li> Item-5 Added</li>").appendTo($("ul li:first"));
  // $("<li> Item-6 Added</li>").prependTo($("ul ul:first"));



  // $(".red-box").after("<div class='red-box'>Red-After</div>");
  // $(".blue-box").before("<div class='blue-box'>Blue-Before</div>");

  // $("<div class='green-box'>Green-Before</div>").insertBefore($(".green-box"));
  // $(".green-box").after(function () {
  //   // Maybe more complex string of new element(s)
  //   return "<div class='green-box'>Func Green</div>";
  // });


  // $(".blue-box").after("<div class='red-box'>Reddddd</div>");
  // $(".blue-box").after($(".red-box"));

  // $(".blue-box").replaceWith($(".red-box"));
  // $(".blue-box").replaceWith($("<div class='red-box'>Reddddd</div>"));

  // $(".blue-box").replaceWith(function () {
  //   return $(".red-box");
  // });
  // $(".blue-box, .red-box").replaceWith("<div class='green-box'>replace Green</div>");
  // $(".blue-box, .red-box").replaceWith($(".green-box"));

  // let removeList = $("#list").remove();
  // $("#content").append(removeList);
  // $("form").children().not("input[type='date']").remove();
  // $("form").children().not("input:text").remove();
  // $("form").children().not("input:radio, label, input:text, input[type='email'], br").remove();
  // $("form").children().not("input:radio, label, input:text, input[type='number'], br").remove();
  // $("form").children().not("input:radio, label, input:text,input:password, input[type='email'], input[type='date'], br").remove();

  // let detachedList = $("#list").detach();
  // $("#content").append(detachedList);

  // $("form").children().not("input:radio, label, input:text,input:password, input[type='email'], input[type='date'], br").detach();


  // $("p:first").empty();
  // // $("p:first").remove();
  // $(".blue-box, .red-box").empty();


  // let checkbox = $("input:checkbox");
  // // console.log(checkbox.prop('checked'));
  // console.log(checkbox.attr('checked'));

  // let range = $("input[type='range']");
  // range.attr('title', 'RangeInput');
  // range.val("1")
  // console.log('attr title is ' + range.attr('title'));
  // console.log('prop title is ' + range.prop('title'));
  // console.log('val value is ' + range.val());
  // console.log('attr value is ' + range.attr('value'));
  // console.log('prop value is ' + range.prop('value'));



  // Image Slide

  // var galImage = $(".gallery").find("img").first();
  // // let galImage = $(".gallery").find("img").eq(0);

  // var images = ["images/laptop-mobile_small.jpg",
  //   "images/laptop-on-table_small.jpg",
  //   "images/people-office-group-team_small.jpg"
  // ];
  // 

  // var i = 0;

  // // setInterval(() => {
  // setInterval(function () {
  //   i = (i + 1) % images.length;
  //   console.log(i);
  //   galImage.fadeOut(function () {
  //   // galImage.slideUp(function () {
  //     $(this).attr('src', images[i]);
  //     $(this).fadeIn();
  //     // $(this).slideDown();
  //   })

  //   // galImage.attr('src', images[i]);
  //   // galImage.fadeIn();

  // }, 2000);

  // var redBox = $(".red-box");

  // redBox.css("user-select", "none");
  // redBox.css("background-color", "#AA7700");

  // var properties = $('p').css("font-size", "15px");
  // // var properties = $('p').css(["font-size", "color", "background-color"]);
  // console.log($('p').css("margin"));
  // console.log(properties);



  // $("a").addClass("fancy-link");
  // $("p:first").addClass("large emphasize");

  // $("li li").addClass(function (index) {
  //   return "item-"+index ; 
  // });

  // $("div").addClass(function (index, currentClass) {
  //   if (currentClass === "dummy") {
  //     $(this).addClass("red-box");
  //   }
  // })


  // $(".green-box").removeClass("green-box").addClass("blue-box");


  // $("li li").toggleClass("emphasize");


  // var gallery = $(".gallery")

  // var images = ["images/laptop-mobile_small.jpg",
  //   "images/laptop-on-table_small.jpg",
  //   "images/people-office-group-team_small.jpg"
  // ];

  // gallery.data("availableImages", images);
  // gallery.data("name", "This is Name of Gallery");

  // console.log(gallery.data("availableImages"));
  // console.log(gallery.data("name"));
  // console.log(gallery.data());

  // var firstPar = $("p:first");
  // var lastPar = $("p:last");

  // console.log(firstPar.text());
  // console.log(firstPar.html());

  // console.log(firstPar.text("<strong>Hello</strong>"));
  // console.log(lastPar.html("<strong>Hello</strong>"));
  // var name = "XYZ";
  // lastPar.html(lastPar.html()+" Mr. "+name);



  //*********  Event-I  *********

  $("#btn-click").click(function (event) {
    console.log(event);
    alert("Button clicked");
  });
  // $("#btn-click").click({
  //   userName: "XYZ"
  // }, function (event) {

  //   greetUser(event.data);
  //   console.log(event);
  //   // alert("Button clicked by "+ event.data.userName);
  // })

  function greetUser(userdDetails) {
    user = userdDetails.userName || "Guest";
    console.log(user);
  }

  $(".red-box").click(function () {
    // $(".red-box").fadeTo(2000,0.5);
    $(this).fadeTo(2000, 0.5);
  })

  $(".green-box").hover(function () {
    $(".red-box").fadeTo(2000, 0.5);
    $(this).html("Box Hovered");
    // $(this).html("<h1>Box Hovered</h1>");
    // $(this).text("<h1>Box Hovered</h1>");
  })

  $("#btn-hover").hover(function () {
    alert("Button Hovered");
  })



  // var blueBox = $(".blue-box");
  // // blueBox.mouseenter(function () {
  // //   // $(this).fadeTo(2000, 0.7);
  // //   $(this).stop().fadeTo(2000, 0.2);
  // //   // $(this).fadeToggle(500);
  // // });
  // // blueBox.mouseleave(function () {
  // //   // $(this).fadeTo(2000, 1);
  // //   $(this).stop().fadeTo(2000, 1);
  // //   // $(this).fadeToggle(500);
  // // });

  // blueBox.hover(function () {
  //   $(this).stop().fadeTo(2000, 0.2);
  // }, function () {
  //   // $(this).stop().fadeTo(2000, 1);
  //   $(this).fadeTo(2000, 1);
  // });



  // $("html").on("click",function () {
  //   console.log("clicked");
  // });
  // $("html").on("click keypress",function () {
  //   console.log("clicked");
  // });


  // Modularize event handling

  // $("html").on("click keypress", logEvent);

  // function logEvent() {
  //   console.log("clicked");
  // }
  // // function logEvent(event) {
  // //   console.log("clicked");
  // //   console.log(event.type);
  // // }

  //Same Handler for multiple events
  // $("html").on("click keypress", function (event) {
  //   console.log("Event occured");
  //   // console.log(event);
  //   // console.log(event.type);
  //   if (event.type == "click") {
  //     console.log("Mouse clicked");
  //   } else {
  //     console.log("Keyboard key Pressed");
  //   }
  // });


  var images = ["images/laptop-mobile_small.jpg",
    "images/laptop-on-table_small.jpg",
    "images/people-office-group-team_small.jpg"
  ];

  var i = 0;
  // var gallery = $(".gallery").find("img").on("click", function () {
  //   i = (i + 1) % images.length;
  //   $(this).fadeOut(function () {
  //     $(this).attr("src", images[i]).fadeIn();
  //   });
  // });
  var gallery = $(".gallery").find("img");
  var fwd = $("#fwd");
  var rev = $("#rev");
  gallery.on("click", function () {
    i = (i + 1) % images.length;
    $(this).fadeOut(function () {
      $(this).attr("src", images[i]).fadeIn();
    });
  });
  fwd.on("click", function () {
    console.log(i);
    i = (i + 1) % images.length;
    console.log(i);
    gallery.fadeOut(function () {
      gallery.attr("src", images[i]).fadeIn();
    });
  });

  rev.on("click", function () {
    console.log(i);
    i = ((i - 1) + images.length) % images.length;
    // i = (i - 1) % images.length;
    // if(i < 0){
    //   i = 2;
    // }

    console.log(i);
    gallery.fadeOut(function () {
      gallery.attr("src", images[i]).fadeIn();
    });
  });

  $("#content").append("<p>Dynamically Added Paragraph</p>");


  $("#content").on("click", "p", "h2",  function () {
    $(this).slideUp();
  });



  $("body").on("mouseenter", "li li", function () {
    $(this).css("color", "#666");
    $(this).css("background-color", "#888");
  });
  $("body").on("mouseleave", "li li", function () {
    $(this).css("color", "#000");
    $(this).css("background-color", "#fff");
  });


  // Gallery Image selection

  var galleryItems = $(".gallery2").find("img");

  galleryItems.css("width", "33%").css("opacity", "0.5");

  galleryItems.on("mouseenter", function () {
    $(this).fadeTo(500, 1);
  })
  galleryItems.on("mouseleave", function () {
    $(this).fadeTo(500, 0.5);
  });
  galleryItems.on("click", function () {
    var image = $(this);
    // $(".gallery2").empty().css("background-color", "#666").css("display","flex").css("justify-content", "center").append(image);
    // galleryItems.eq(0).css("width", "25%");
    // galleryItems.eq(1).css("width", "48%");
    // galleryItems.eq(2).css("width", "25%");

    galleryItems.not($(this)).css("width", "25%").css("opacity", "0.2");
    $(this).css("width", "45%").css("border", "2px solid red");
  });


  // Arrow key

  $("html").keydown(function (event) {
    console.log(event.which);
    console.log(event);
    ckey = event.which;

    var arrowRight = 39;
    var arrowLeft = 37;

    if (event.which == (arrowRight)) {
      $(".blue-box").stop().animate({
        marginLeft: "+=100px",
        position: "relative"
      }, 2000);
    }
    else if (event.which == arrowLeft) {
      $(".blue-box").stop().animate({
        marginLeft: "0",
        position: "relative"
      }, 2000);
    }
  });




  // Event - II Forms

  var inputFields = $("input:text, input:password, textarea");
  inputFields.focus(function () {
    $(this).css("box-shadow", "0 0 4px #666666");
    // $(this).css("box-shadow", "0 0 4px red");
  });

  inputFields.blur(function () {
    $(this).css("box-shadow", "none");
  })

  $("#name").blur(function () {
    var text = $(this).val();
    if (text.length < 3) {
      $(this).css("box-shadow", "0 0 4px red");
    }
    else {
      $(this).css("box-shadow", "0 0 4px green");
    }
  })


  $("#cb").change(function () {
    var isChecked = $(this).is(":checked");  //prop("checked")
    console.log(isChecked);
    // console.log($(this).prop("checked"));

    if (isChecked) {
      $(this).add("label[for='cb']").css("box-shadow", "0 0 4px #181");
      // $(this).css("box-shadow", "0 0 4px #181");
      $("label[for='cb']").css("color", "#181");
    } else {
      $(this).add("label[for='cb']").css("box-shadow", "0 0 4px #811");
      // $(this).css("box-shadow", "0 0 4px #811");
      $("label[for='cb']").css("color", "#811");
    }
  });

  $("#selection").change(function () {
    var selectedOption = $(this).find(":selected").text();
    // alert(selectedOption);
    console.log(selectedOption);
  })

  $("#form").submit(function (event) {
    var textarea = $("#message");
    if (textarea.val().trim() == "") {
      textarea.css("box-shadow", "0 0 4px #811");
      event.preventDefault();
    }
  });


  // $("#form2").submit(function (event) {
  //   var name = $("#name2").val();
  //   // var name = $(".form2").children("#name").val();
  //   var password = $("#password2").val();
  //   var message = $("#message2").val();
  //   var isChecked = $("#checkbox2").is(":checked");

  //   validateNameField(name, event);
  //   validatePasswordField(password, event);
  //   validateMessageField(message, event);
  //   validateCheckboxField(isChecked, event);
  // });

  // function validateCheckboxField(isChecked, event) {
  //   if (!isChecked){
  //     $("#checkbox2-feedback").text("Agree to declaration");
  //     event.preventDefault();
  //   } else {
  //     $("#checkbox2-feedback").text("Looks Good!");
  //   }
  // }
  // function validateNameField(name, event) {
  //   if (!isValidName(name)){
  //     $("#name2-feedback").text("Name should contain min. 3 char");
  //     event.preventDefault();
  //   } else {
  //     $("#name2-feedback").text("Looks Good!");
  //   }
  // }

  // function isValidName(name) {
  //   return name.length >= 2;
  // }
  // function validatePasswordField(password, event) {
  //   if (!isValidPassword(password)){
  //     $("#password2-feedback").text("Password should contain min. 6 char");
  //     event.preventDefault();
  //   } else {
  //     $("#password2-feedback").text("Looks Good!");
  //   }
  // }

  // function isValidPassword(password) {
  //   return password.length >= 6;
  // }
  // function validateMessageField(message, event) {
  //   if (!isValidMessage(message)){
  //     $("#message2-feedback").text("Message required");
  //     event.preventDefault();
  //   } else {
  //     $("#message2-feedback").text("Looks Good!");
  //   }
  // }

  // function isValidMessage(message) {  
  //   return message.trim() !== "";   
  // }



  // Fast Feedback

  var form = $("#form2");

  enableFastFeedback(form);

  form.submit(function (event) {
    var name = $("#name2").val();
    // var name = $("#form2").children("#name2").val();
    // var name = $("#form2").find("#name2").val();
    var password = $("#password2").val();
    var message = $("#message2").val();
    var isChecked = $("#checkbox2").is(":checked");

    validateNameField(name, event);
    validatePasswordField(password, event);
    validateMessageField(message, event);
    validateCheckboxField(isChecked, event);
  });

  function enableFastFeedback(formElement) {
    var nameInput = formElement.find("#name2");
    var passwordInput = formElement.find("#password2");
    var messageInput = formElement.find("#message2");
    var checkboxInput = formElement.find("#checkbox2");

    nameInput.blur(function (event) {
      var name = $(this).val();

      validateNameField(name, event);

      if (!isValidName(name)) {
        $(this).css("box-shadow", "0 0 4px #811");
      } else {
        $(this).css("box-shadow", "0 0 4px #181");
      }
    });

    passwordInput.blur(function (event) {
      var password = $(this).val();
      validatePasswordField(password, event);

      if (!isValidPassword(password)) {
        $(this).css("box-shadow", "0 0 4px #811");
      } else {
        $(this).css("box-shadow", "0 0 4px #181");
      }
    });
    messageInput.blur(function (event) {
      var message = $(this).val();
      validateMessageField(message, event);

      if (!isValidMessage(message)) {
        $(this).css("box-shadow", "0 0 4px #811");
      } else {
        $(this).css("box-shadow", "0 0 4px #181");
      }
    });
    checkboxInput.change(function (event) {
      var isChecked = $(this).is(":checked");
      validateCheckboxField(isChecked, event);

      if (!isChecked) {
        $(this).add("label[for='checkbox2']").css("box-shadow", "0 0 4px #811");
      } else {
        $(this).add("label[for='checkbox2']").css("box-shadow", "0 0 4px #181");
      }
    });
  }


  function validateCheckboxField(isChecked, event) {
    if (!isChecked) {
      $("#checkbox2-feedback").text("Agree to declaration");
      event.preventDefault();
    } else {
      $("#checkbox2-feedback").text("Looks Good!");
    }
  }

  function validateNameField(name, event) {
    if (!isValidName(name)) {
      $("#name2-feedback").text("Name should contain min. 3 char");
      event.preventDefault();
    } else {
      $("#name2-feedback").text("Looks Good!");
    }
  }

  function isValidName(name) {
    return name.length >= 2;
  }


  function validatePasswordField(password, event) {
    if (!isValidPassword(password)) {
      $("#password2-feedback").text("Password should contain min. 6 char");
      event.preventDefault();
    } else {
      $("#password2-feedback").text("Looks Good!");
    }
  }

  function isValidPassword(password) {
    return password.length >= 6;
  }


  function validateMessageField(message, event) {
    if (!isValidMessage(message)) {
      $("#message2-feedback").text("Message required");
      event.preventDefault();
    } else {
      $("#message2-feedback").text("Looks Good!");
    }
  }

  function isValidMessage(message) {
    return message.trim() !== "";
  }

  $("#code").load("js/temp.js");

  // $("#code").load("js/temp.js", function (response, status) {
  //   if (status == "error") {
  //     alert("Not Found");
  //   }
  //   console.log(response +" & status is : "+ status);
  // });

  // $("#code").load("js/temp1.js", function (response, status) {
  //   if (status == "error") {
  //     alert("Not Found");
  //   }
  //   console.log(response +" & status is : "+ status);
  // });

  var flickerApiUrl = "https://www.flickr.com/services/feeds/photos_public.gne?jsoncallback=?";

  // $.getJSON(flickerApiUrl,
  //   {
  //     //options in key-value pair
  //   }).done(function () {
  //     //success
  //   }).fail(function () {
  //     //fail
  //   });

  $.getJSON(flickerApiUrl,
    {
      //options in key-value pair
      tags: "sun,beach",
      tagmode: "any",
      format: "json"
    }).done(function (data, status, response) {
      //success
      console.log("Successed");
      console.log(data);
      $.each(data.items, function (index, item) {
        // console.log(item);
        // $("<img>").attr("src", item.media.m).css("height", "300px").css("width", "300px").css("object-fit", "fill").appendTo("#flicker");
        $("<img>").attr("src", item.media.m).css("height", "500px").css("width", "400px").appendTo("#flicker");
        // var newImage = $("<img>").attr("src", item.media.m);
        // console.log("image width is "+ $("<img>").prop("width"));
        // console.log("image height is "+ $("<img>").prop("height"));

       
        if (index == 3)
          return false;
      })

      // console.log(status);
      // console.log(response.status);
    }).fail(function (data) {
      //fail
      console.log("Failed");
    });



  var pokeUrl = "https://pokeapi.co/api/v2/generation/1";
  var pokeUrlByName = "https://pokeapi.co/api/v2/pokemon/";

  //Normal without link
  // $.getJSON(pokeUrl).done(function (data) {
  // // $.getJSON(pokeUrlByName).done(function (data) {
  //   console.log(data);
  //   $.each(data.pokemon_species, function (index, pokemon) {
  //     var name = pokemon.name.charAt(0).toUpperCase() + pokemon.name.slice(1);
  //     var link = $("<a>").attr("id", "pokemon.name").attr("href", "#").append($("<strong>").text(name));
  //     // console.log(name);
  //     var par = $("<p>").html("Pokemon Sp.No. "+ (index+1) + " is "+ name);
  //     var par = $("<p>").html("Pokemon Sp.No. " + (index + 1) + " is ").append(link);
  //     par.appendTo("#pokemon"); 

  //   });

  // }).fail(function (data) {
  //   //fail
  //   console.log("Failed");
  // }).always(function () {
  //   console.log("Always Block");
  //   var par = $("<p>").html("From Always Block");
  //   par.appendTo("#pokemon");

  // })


  // function getSize() {
  //   let min = 200;
  //   let max = 250;
  //   let h = min + Math.round((max - min) * Math.random());
  //   let w = min + Math.round((max - min) * Math.random());

  //   return h+'x'+w;
  // }

  //with link
  $.getJSON(pokeUrl).done(function (data) {
    // $.getJSON(pokeUrlByName).done(function (data) {
    console.log(data);
    $.each(data.pokemon_species, function (index, pokemon) {
      var name = pokemon.name.charAt(0).toUpperCase() + pokemon.name.slice(1);
      var link = $("<a>").attr("id", "pokemon.name").attr("href", "#").append($("<strong>").text(name));
      // var link = $("<a>").attr("id", "pokemon.name").attr("href", "#").append(name);
      // console.log(name);
      var par = $("<p>").html("Pokemon Sp.No. " + (index + 1) + " is ").append(link);
      par.appendTo("#pokemon");

      if(index == 3){
        return false;
      }


      link.click(function (event) {
        // var iSize = getSize();
        $.getJSON(pokeUrlByName + pokemon.name).done(function (details) {
          console.log(details);
          var pokemonDiv = $("#pokemonD");
          pokemonDiv.empty();
          
          // pokemonDiv.append("<h2>" + name + "</h2>");
          pokemonDiv.append($("<h2>").append(name));
          // pokemonDiv.append($("<img>").attr("src","details.sprites.back_default"));
          // pokemonDiv.append("<img src='+details.sprites.front_default+' >");

          var pokeImg = $("<img>").css("height", "250px").css("width", "250px");
          pokeImg.attr("src", "https://source.unsplash.com/random/");


          pokemonDiv.append(pokeImg);


        });
        event.preventDefault();
      });


    });


  }).fail(function (data) {
    //fail
    console.log("Failed");
  }).always(function () {
    console.log("Always Block");
    var par = $("<p>").html("From Always Block");
    par.appendTo("#pokemon");

  })


});