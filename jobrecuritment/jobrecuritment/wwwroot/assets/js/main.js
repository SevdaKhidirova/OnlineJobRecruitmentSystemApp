$(document).ready(function () {
  $(".login").click(function () {
    $("#login").show();
  });
  $(".remove").click(function () {
    $("#login").hide();
  });

  $(".profile").click(function () {
    $(".info-area").css("display", "block");
  });

  $(".remove-profile").click(function () {
    $(".info-area").css("display", "none");
  });

  // $(".phone-number").click(function(){
  //   let input=$(".phone-number");
  //   input.innerText="saa";
  //   console.log(input.innerText)
  //     input.value="+994";
  // });

  $(".toggle-password1").click(function () {
    $(this).toggleClass("bi bi-eye-slash");
    var input = $($(this).attr("toggle"));
    if (input.attr("type") == "password") {
      input.attr("type", "text");
    } else {
      input.attr("type", "password");
    }
  });

  $(".toggle-password2").click(function () {
    $(this).toggleClass("bi bi-eye-slash");
    var input = $($(this).attr("toggle"));
    if (input.attr("type") == "password") {
      input.attr("type", "text");
    } else {
      input.attr("type", "password");
    }
  });

  // $(".circle").click(function () {
  //   $(this).css("color","black");
  // });


//

// Add interest item
let letAdd = true;
$(".add_interest_btn").click((e) => {
  let seletedItemText = $(".interets_items").find(":selected").text();
  let selectedItemValue = $(".interets_items").find(":selected").val();
  $(".interests_list")
    .find("li")
    .each((index, elem) => {
      if ($(elem).attr("data-id") == selectedItemValue) {
        // alert("Bu artıq mövcuddur");
        letAdd = false;
      }
    });

  if (letAdd)
    $(".interests_list").append(` 
  <li
  data-id="${selectedItemValue}"
   class="list-group-item d-flex justify-content-between align-items-start"
   >
      <div class="ms-2 me-auto">
        <div >${seletedItemText}</div>
      </div>
      <span class="badge bg-danger depth-4 rounded-pill delete_interest_item "
      ><i data-id="${selectedItemValue}" class="bi bi-trash"></i
      ></span>
</li>`);
  letAdd = true;
});

// Remove interest item
$(".interests_list").on("click", ".delete_interest_item", (e) => {
  e.currentTarget.closest("li").remove();
});

    $(".register-checkbox").click(() => {
        
        $(".register-adress").closest("div").toggleClass("d-none");
    });


$(".add_education_item").click(()=>{
  let selectDegreeVal=$(".degree-items").find(":selected").val();
  let selectDegreeText=$(".degree-items").find(":selected").text();
  let selectUniVal=$(".university-items").find(":selected").val();
  let selectUniText=$(".university-items").find(":selected").text();
    let entranceYear = $("#entranceY").val();
    let entranceScore = $("#entrances").val();
  let graduationYear = $("#graduationY").val();
    let profession = $("#specilaiz").val();
  
  let array=[selectDegreeText,selectUniText,entranceYear,entranceScore,graduationYear,profession];
  function myFunction(value, index, array) {
    return value != "";
  }
  let notNull = array.every(myFunction);
  if(notNull==true){
    $(".education-info").append(`
    <div class="info-wrapper">
    <p class="universisty" data-id="${selectUniVal}">${selectUniText}</p>
    <p class="universisty-degree" data-id="${selectDegreeVal}">${selectDegreeText}</p>
    <p class="year">${entranceYear}-${graduationYear}</p>
    <p class="prof">${profession} - ${entranceScore} &nbsp; score</p>
    <span class="icons">
        <i class="bi bi-pencil-fill"></i>
        <i class="bi bi-trash-fill delete_education_item"></i>
    </span>
 </div>
    `);
      $("#entranceYear").val("");
      $("#entrancescore").val("");
      $("#graduationYear").val("");
      $("#specilaization").val("");
  }
 
});
//edit-code

// $(".education-info").on("click", ".edit_education_item", (e) => {
//   e.currentTarget.closest("div").remove();
//   let item=$(".edit_education_item").closest(".year");
//   console.log(item.innerHtml)
//   console.log(e.currentTarget.closest("p").val())

// });

$("#add_experience_item").click(()=>{
    let companyName = $("#exampleInputCompany").val();
    let departmentName = $("#exampleInputDepartment").val();
    let responsibilites = $("#exampleInputResponse").val();
    let startYear = $("#exampleInputYear1").val();
    let endYear = $("#exampleInputYear2").val();
 /*  let reason=$(".reason").val();*/
  
   let array=[companyName,departmentName,responsibilites,startYear];
   function myFunction(value, index, array) {
     return value != "";
   }
   let notNull = array.every(myFunction);
if(notNull==true){
  $(".experience_wrapper").append(`
  <div class="experience-card mb-2">
  <p class="company_name">${companyName}</p>
  <p class="department">${departmentName} </p>
  <p class="profession_name">${responsibilites}</p>
  <p>${startYear} - ${endYear}</p>
  <span class="icons">
      <i class="bi bi-pencil-fill"></i>
      <i class="bi bi-trash-fill delete_experience_item"></i>
  </span>
</div>
  `);
}
    $("#exampleInputCompany").val("");
    $("#exampleInputDepartment").val("");
    $("#exampleInputResponse").val("");
    $("#exampleInputYear1").val("");
    $("#exampleInputYear2").val("");
});

$(".work_check").click(function () {
  $(".reason_input").toggleClass("d-none");
  (".response").val("");
});


$(".education-info").on("click", ".delete_education_item", (e) => {
  e.currentTarget.closest("div").remove();
});

$(".experience-card").on("click", ".delete_experience_item", (e) => {
  e.currentTarget.closest("div").remove();
});

$(".no-button").click(function(){
  let insertButton=$(".insert_button");
  insertButton.css("visibility","hidden")
});

$(".yes_button").click(function(){
  let insertButton=$(".insert_button");
  insertButton.css("visibility","visible")
});
  
$(".add_language_item").click(()=>{
   let language=$("#add_language_items").find(":selected").text();
   let read=$("#add_language_read").find(":selected").text();
   let write=$("#add_language_write").find(":selected").text();
   let speak=$("#add_language_speak").find(":selected").text();

   $(".language_cards_wrapper").append(`
        <div class="language_card">
        <p><b>${language}</b></p>
        <p>Read - ${read}</p>
        <p>Write - ${write}</p>
        <p>Speak - ${speak}</p>
        <span class="icons">
            <i class="bi bi-pencil-fill"></i>
            <i class="bi bi-trash-fill delete_language_item"></i>
        </span>
      </div>
   `);

   $("#add_language_items").val("Select");
   $("#add_language_read").val("Read");
   $("#add_language_write").val("Write");
   $("#add_language_speak").val("Speak");

});
$(".language_cards_wrapper").on("click", ".delete_language_item", (e) => {
  e.currentTarget.closest(".language_card").remove();
});

$(".project-filter input").click(function (e) {
  // e.preventDefault();
  $(".project-filter input").removeClass("active");
  $(this).addClass("active");

  let target = $(this).attr("data-target");
  if (target == "all") {
      $(".project-wrapper").removeClass("d-none");
  }
  else {
      $(".project-wrapper").addClass("d-none");
      $(".project-wrapper." + target).removeClass("d-none");
  }
});
  
    //$(".span_circle").click(function () {
    //    console.log("asdad");
    //    $(this).closest(".circle").addClass("circle1");
    //});

    //$("#aply_button").click(function () {
    //    $("#aply_button").val() = "Aplied";
    //});

});