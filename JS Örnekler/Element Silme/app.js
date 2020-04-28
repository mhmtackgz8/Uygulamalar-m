// // // // const a =document.getElementById("filter");

// // // // // a.addEventListener("focus",function(e){
// // // // //     console.log("Naber")
// // // // //     console.log(e);
// // // // //     console.log(e.type);
// // // // //     console.log(e.target);
// // // // //     console.log(e.target.placeholder);
// // // // //     console.log(e.target.className);

// // // // // });
// // // // const todoforce=document.getElementById("todo-form");
// // // // todoforce.addEventListener("submit",submitform)
// // // // function submitform(e){
// // // //     console.log("Submit Eventi");

// // // //     //e.preventDefault();
// // // // }

// // // // document.addEventListener("keypress",calıs)
// // // // function calıs(e){
// // // //     //console.log(e.which);
// // // //     console.log(e.key,":"+e.which);
// // // //     console.log("Calıştı");
// // // // }
// // // document.addEventListener("keydown",calıs)
// // // function calıs(e){
// // //     //console.log(e.which);
// // //     console.log(+e.which);
// // //     console.log("Calıştı:" +"Basılan tuş: "+e.key);
// // // }


// // // document.addEventListener("keyup",calıs)
// // // function calıs(e){
// // //     //console.log(e.which);
// // //     console.log(+e.which);
// // //     console.log("Calıştı:" +"Basılan tuş: "+e.key);
// // // }


// // // const header=document.querySelector(".card-header");
// // // const todoınput=document.querySelector("#todo");
// // // todoınput.addEventListener("keyup",changetext);
// // // function changetext(e){
// // //     header.textContent=e.target.value;
// // //     //console.log(e.target.value);
// // //     console.log(header.textContent);
// // // }

// // const cardbody=document.querySelectorAll(".card-body")[1];
// // const title=document.querySelector("#tasks-title");

// // //Click
// // title.addEventListener("click",run);
// // function run(e){
// //     console.log(e.type);
// // }

// // cardbody.addEventListener("mouseover",run);


// const filter=document.getElementById("filter");
// console.log(filter);
// document.addEventListener("DOMContentLoaded",load);
// function load(e){
// console.log("sayfa yüklendi 1");
// }


// filter.addEventListener("focus",run);
// filter.addEventListener("blur",run);

// function run(e){
//     console.log(e.type);

// }
const filter=document.getElementById("filter");
filter.addEventListener("paste",run)
function run(e){
    
    console.log(e.type);
}