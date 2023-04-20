@charset "UTF-8";
@import url("https://fonts.googleapis.com/css2?family=Montserrat:wght@500&family=Poiret+One&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;1,500&family=Source+Sans+Pro:wght@200;300;400&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Urbanist:wght@200;300;400;600;700&display=swap");
@import url(https://fonts.googleapis.com/css?family=Finger+Paint);
* {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
}

/*Components*/
#quarta-pagina {
  padding: 50px 0px 0px 0px;
  width: 100%;
  height: 0 auto;
  background: linear-gradient(90deg, rgb(7, 9, 15) 0%, rgb(0, 0, 0) 50%, rgb(7, 9, 15) 100%);
  align-items: center;
  justify-content: center;
}

.container-tecnologias {
  position: relative;
  display: flex;
  align-items: center;
  justify-content: space-between;
  align-items: center;
  flex-wrap: wrap;
  margin: auto;
  width: 30%;
  height: 100%;
  flex-direction: row;
}

.tecnologias {
  width: 100px;
  height: 100px;
  background-color: rgba(42, 42, 42, 0.152);
  border: 1px solid rgb(255, 0, 0);
  border-radius: 12px;
  margin: 10px 10px;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-wrap: wrap;
  transition: ease 0.2s;
  background-position: center;
  background-repeat: no-repeat;
}

.tecnologias img {
  display: block;
  margin: 30px;
  left: 0;
  right: 0;
  top: 0;
  bottom: 0;
  margin: auto;
  justify-content: center;
  align-items: center;
  width: 80px;
  height: 80px;
}

.tecnologias .icones-tecnologias {
  transition: ease-in-out 0.4s;
}

.tecnologias:hover .icones-tecnologias {
  opacity: 0;
}

.tecnologias:hover {
  background-color: rgb(0, 0, 0);
  transform: scale(1.2);
  background-size: 80px;
  background-position: center;
  background-repeat: no-repeat;
  box-shadow: 0px 0px 15px 2px #ff0000;
}

.html:hover {
  background-image: url(../img/html-h.png);
}

.css:hover {
  background-image: url(../img/css-h.png);
}

.javascript:hover {
  background-image: url(../img/js-h.png);
  background-size: 80px;
}

.github:hover {
  background-image: url(../img/github-h.png);
}

.vtex:hover {
  background-image: url(../img/vtex-h.png);
}

.sass:hover {
  background-image: url(../img/sass-h.png);
}

.react:hover {
  background-image: url(../img/react-h.png);
}

.git:hover {
  background-image: url(../img/git-h.png);
}

.escrita-habilidades {
  text-align: center;
  font-size: 90px;
  font-family: Poiret One;
  height: 100%;
  overflow: hidden;
  color: rgb(0, 0, 0);
  transform: translateY(-22px);
}

.letter-h {
  position: relative;
  top: calc(50% - 60px);
  color: rgb(255, 60, 0);
  text-shadow: 0px 0px 10px rgb(255, 0, 0), 0px 0px 20px rgb(255, 0, 0), 0px 0px 40px rgb(255, 0, 0);
}

.letter-h:nth-child(1) {
  -webkit-animation: fade 4s infinite 200ms;
  animation: fade 4s infinite 200ms;
}
.letter-h:nth-child(2) {
  -webkit-animation: fade 4s infinite 400ms;
  animation: fade 4s infinite 400ms;
}
.letter-h:nth-child(3) {
  -webkit-animation: fade 4s infinite 600ms;
  animation: fade 4s infinite 600ms;
}
.letter-h:nth-child(4) {
  -webkit-animation: fade 4s infinite 800ms;
  animation: fade 4s infinite 800ms;
}
.letter-h:nth-child(5) {
  -webkit-animation: fade 4s infinite 1000ms;
  animation: fade 4s infinite 1000ms;
}
.letter-h:nth-child(6) {
  -webkit-animation: fade 4s infinite 1200ms;
  animation: fade 4s infinite 1200ms;
}
.letter-h:nth-child(7) {
  -webkit-animation: fade 4s infinite 1400ms;
  animation: fade 4s infinite 1400ms;
}
.letter-h:nth-child(8) {
  -webkit-animation: fade 4s infinite 1600ms;
  animation: fade 4s infinite 1600ms;
}
.letter-h:nth-child(9) {
  -webkit-animation: fade 4s infinite 1800ms;
  animation: fade 4s infinite 1800ms;
}
.letter-h:nth-child(10) {
  -webkit-animation: fade 4s infinite 2000ms;
  animation: fade 4s infinite 2000ms;
}
.letter-h:nth-child(11) {
  -webkit-animation: fade 4s infinite 2200ms;
  animation: fade 4s infinite 2200ms;
}

@-webkit-keyframes fade {
  50% {
    opacity: 0.02;
  }
}
@keyframes fade {
  50% {
    opacity: 0.02;
  }
}
.container-descricao {
  font-family: "Quando", serif;
  font-size: 20px;
  max-width: 40%;
  background-color: red;
  position: relative;
  align-items: center;
  justify-content: center;
  align-items: center;
}

.texto-descricao {
  color: white;
  display: flex;
  flex-wrap: wrap;
  justify-content: start;
  gap: 50px;
  padding-bottom: 70px;
  margin-left: 200px;
}

.texto-descricao2 {
  color: white;
  display: flex;
  flex-wrap: wrap;
  justify-content: start;
  gap: 50px;
  padding-bottom: 70px;
  margin-right: 200px;
}

.quarto-container {
  height: 0 auto;
  width: 0 auto;
  align-items: center;
  justify-content: center;
  align-items: center;
  padding-bottom: 60px;
  text-align: center;
  margin: 0 auto;
  display: flex;
  flex-direction: row;
  justify-content: space-around;
}

.div-texto {
  font-family: "Montserrat", sans-serif;
  font-weight: 700;
  position: absolute;
  left: 250px;
  font-size: 34px;
  transition: opacity 0.9s ease-in-out;
  color: rgb(255, 255, 255);
  text-shadow: 0px 0px 10px red, 0px 0px 20px red, 0px 0px 40px red;
}

.container-tecnologias:hover + .div-texto + .div-texto2 {
  display: block;
}

.div-texto2 {
  font-family: "Montserrat", sans-serif;
  font-weight: 700;
  position: absolute;
  font-size: 24px;
  transition: opacity 0.9s ease-in-out;
  color: white;
  width: 400px;
  height: 0 auto;
  right: 180px;
}

#terceira-pagina {
  display: flex;
  align-items: center;
  padding-bottom: 60px;
  justify-content: center;
  background: radial-gradient(circle, rgb(12, 15, 23) 4%, rgb(9, 11, 14) 95%, rgba(10, 0, 0, 0.96) 100%);
  overflow-x: hidden;
  overflow-y: hidden;
  height: 0 auto;
  font-family: "Urbanist", sans-serif;
}

a {
  text-decoration: none;
}

input {
  display: none;
}

.terceiro-container {
  width: 100%;
  height: 100%;
  max-width: 600px;
  max-height: 600px;
  display: flex;
  transform-style: preserve-3d;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}

.cards {
  width: 300px;
  height: 400px;
  position: relative;
  perspective: 2000px;
  transform-style: preserve-3d;
}

.cards label {
  position: absolute;
  width: 320px;
  height: 420px;
  margin: auto;
  cursor: pointer;
  transition: transform 0.55s ease;
}

.cards .card {
  position: relative;
  height: 100%;
  background-color: #070000;
  border-radius: 5px;
  border: 3px solid rgba(255, 0, 0, 0.35);
  padding: 30px 35px;
}

.card .image {
  display: flex;
  justify-content: center;
}

.card .image img {
  border-radius: 5px;
  box-shadow: 15px 15px 40px rgba(0, 0, 0, 0.5);
  width: 200px;
  height: 220px;
  object-fit: cover;
}

.card .descricao-projeto {
  display: block;
  text-align: center;
  padding-top: 10px;
}

.descricao-projeto span {
  display: block;
}

.descricao-projeto .nome-projeto {
  font-size: 24px;
  color: var(--current-color1);
  letter-spacing: 2px;
  transition: all 0.6s ease;
}

.descricao-projeto .lorem {
  font-size: 15.5px;
  color: #ECEAED;
}

.card .btn-contact {
  width: 100%;
  margin: 10px auto;
  border-radius: 5px;
  background-color: var(--current-color1);
  display: flex;
  align-items: center;
  justify-content: center;
  color: #fff;
  font-size: 16px;
  font-weight: 700;
  transition: all 0.7s ease;
}

#c1:checked ~ .cards #slide4,
#c2:checked ~ .cards #slide5,
#c3:checked ~ .cards #slide1,
#c4:checked ~ .cards #slide2,
#c5:checked ~ .cards #slide3 {
  box-shadow: 0 15px 35px 0 rgba(0, 0, 0, 0.45);
  transform: translate3d(-70%, 0, -220px);
  --current-color1: #ECEAED;
  --current-color2: #404457;
}

#c1:checked ~ .cards #slide5,
#c2:checked ~ .cards #slide1,
#c3:checked ~ .cards #slide2,
#c4:checked ~ .cards #slide3,
#c5:checked ~ .cards #slide4 {
  box-shadow: 0 20px 40px 0 rgba(0, 0, 0, 0.45);
  transform: translate3d(-35%, 0, -120px);
  --current-color1: #ECEAED;
  --current-color2: #404457;
}

#c1:checked ~ .cards #slide1,
#c2:checked ~ .cards #slide2,
#c3:checked ~ .cards #slide3,
#c4:checked ~ .cards #slide4,
#c5:checked ~ .cards #slide5 {
  box-shadow: 0 25px 50px 0 rgba(0, 0, 0, 0.5);
  transform: translate3d(0, 0, 0);
  --current-color1: red;
  --current-color2: #ECEAED;
}

#c1:checked ~ .cards #slide2,
#c2:checked ~ .cards #slide3,
#c3:checked ~ .cards #slide4,
#c4:checked ~ .cards #slide5,
#c5:checked ~ .cards #slide1 {
  box-shadow: 0 20px 40px 0 rgba(0, 0, 0, 0.45);
  transform: translate3d(35%, 0, -120px);
  --current-color1: #ECEAED;
  --current-color2: #404457;
}

#c1:checked ~ .cards #slide3,
#c2:checked ~ .cards #slide4,
#c3:checked ~ .cards #slide5,
#c4:checked ~ .cards #slide1,
#c5:checked ~ .cards #slide2 {
  box-shadow: 0 15px 35px 0 rgba(0, 0, 0, 0.45);
  transform: translate3d(70%, 0, -220px);
  --current-color1: #ECEAED;
  --current-color2: #404457;
}

/*texto*/
.escrita-projetos {
  text-align: center;
  justify-content: center;
  font-size: 60px;
  font-family: "Montserrat", sans-serif;
  height: 100%;
  overflow: hidden;
  color: rgb(255, 255, 255);
  padding: 40px;
}

.letter-2 {
  position: relative;
  top: calc(50% - 60px);
  text-shadow: 0px 0px 10px red, 0px 0px 20px red, 0px 0px 40px red, 0px 0px 80px red, 0px 0px 120px red;
}

.letter-2:nth-child(1) {
  -webkit-animation: fade 4s infinite 200ms;
  animation: fade 4s infinite 200ms;
  animation-direction: alternate;
}
.letter-2:nth-child(2) {
  -webkit-animation: fade 4s infinite 400ms;
  animation: fade 4s infinite 400ms;
  animation-direction: alternate;
}
.letter-2:nth-child(3) {
  -webkit-animation: fade 4s infinite 600ms;
  animation: fade 4s infinite 600ms;
  animation-direction: alternate;
}
.letter-2:nth-child(4) {
  -webkit-animation: fade 4s infinite 800ms;
  animation: fade 4s infinite 800ms;
  animation-direction: alternate;
}
.letter-2:nth-child(5) {
  -webkit-animation: fade 4s infinite 1000ms;
  animation: fade 4s infinite 1000ms;
  animation-direction: alternate;
}
.letter-2:nth-child(6) {
  -webkit-animation: fade 4s infinite 1200ms;
  animation: fade 4s infinite 1200ms;
  animation-direction: alternate;
}
.letter-2:nth-child(7) {
  -webkit-animation: fade 4s infinite 1400ms;
  animation: fade 4s infinite 1400ms;
  animation-direction: alternate;
}
.letter-2:nth-child(8) {
  -webkit-animation: fade 4s infinite 1400ms;
  animation: fade 4s infinite 1600ms;
  animation-direction: alternate;
}

@-webkit-keyframes fade {
  50% {
    opacity: 0.02;
  }
}
@keyframes fade {
  50% {
    opacity: 0.02;
  }
}
#segunda-pagina {
  padding: 50px 0px 0px 0px;
  width: 100%;
  height: 0 auto;
  background: linear-gradient(90deg, rgb(7, 9, 15) 0%, rgb(0, 0, 0) 50%, rgb(7, 9, 15) 100%);
}

.segundo-container {
  padding: 50px;
  margin: 0 auto;
  display: flex;
  flex-direction: row;
  text-align: center;
  align-items: center;
  justify-content: center;
  display: flex;
  flex-wrap: wrap;
}

.sobre-mim {
  display: flex;
  flex-direction: column;
  padding: 50px;
  text-align: center;
  align-items: center;
  justify-content: center;
  font-family: "Poppins", sans-serif;
  font-weight: 200;
}
.sobre-mim p {
  text-indent: 50px;
  font-size: 20px;
  max-width: 600px;
  color: white;
}

/*card foto*/
.foto-card {
  position: relative;
  width: 300px;
  height: 400px;
  overflow: hidden;
}

.foto-card span:first-of-type {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 3px;
  background: linear-gradient(to right, transparent, #f42929);
  animation: animacao1 2s linear infinite;
}

@keyframes animacao1 {
  0% {
    transform: translateX(-100%);
  }
  100% {
    transform: translateX(100%);
  }
}
.foto-card span:nth-of-type(2) {
  position: absolute;
  top: 0;
  right: 0;
  width: 3px;
  height: 100%;
  background: linear-gradient(to bottom, transparent, #f42929);
  animation: animacao2 2s linear infinite;
  animation-delay: 1s;
}

@keyframes animacao2 {
  0% {
    transform: translateY(-100%);
  }
  100% {
    transform: translateY(100%);
  }
}
.foto-card span:nth-of-type(3) {
  position: absolute;
  bottom: 0;
  right: 0;
  width: 100%;
  height: 3px;
  background: linear-gradient(to left, transparent, #f42929);
  animation: animacao3 2s linear infinite;
}

@keyframes animacao3 {
  0% {
    transform: translateX(100%);
  }
  100% {
    transform: translateX(-100%);
  }
}
.foto-card span:last-of-type {
  position: absolute;
  top: 0;
  left: 0;
  width: 3px;
  height: 100%;
  background: linear-gradient(to top, transparent, #f42929);
  animation: animacao4 2s linear infinite;
  animation-delay: 1s;
}

@keyframes animacao4 {
  0% {
    transform: translateY(100%);
  }
  100% {
    transform: translateY(-100%);
  }
}
/*hover img*/
.foto-card {
  position: relative;
  overflow: hidden;
}
.foto-card img {
  width: 100% transition all linear 0.7s;
  transition-duration: 1.4s;
  width: 40px;
}
.foto-card .foto-hover {
  position: absolute;
  top: 0;
  left: 0;
  opacity: 0;
}

.foto-card:hover img {
  opacity: 0;
}

.foto-card:hover img.foto-hover {
  opacity: 1;
  filter: blur(5px);
}

.foto-card .texto-card {
  font-family: "Source Sans Pro", sans-serif;
  visibility: hidden;
  position: relative;
  width: 100%;
  height: 100%;
  margin-top: -270px;
  padding: 10px;
  color: white;
  z-index: 1;
  text-align: center;
  font-size: 24px;
}

.foto-card:hover .texto-card {
  visibility: visible;
  background-size: cover;
  background: rgba(0, 0, 0, 0.163);
  transition-delay: 0.3s;
  cursor: pointer;
  text-shadow: 0px 0px 3px black;
}

.btn-curriculo {
  padding: 10px;
  border-radius: 22px;
  font-size: 22px;
  background: red;
  color: white;
}

.btn-curriculo:hover {
  padding: 10px;
  border-radius: 22px;
  font-size: 22px;
  background-color: black;
  color: red;
}

.escrita-sobre {
  text-align: center;
  font-size: 90px;
  font-family: Poiret One;
  height: 100%;
  overflow: hidden;
}

.letter {
  position: relative;
  color: rgb(255, 60, 0);
  text-shadow: 0px 0px 10px rgb(255, 0, 0), 0px 0px 20px rgb(255, 0, 0), 0px 0px 40px rgb(255, 0, 0);
}

.letter:nth-child(1) {
  -webkit-animation: fade 4s infinite 200ms;
  animation: fade 4s infinite 200ms;
}
.letter:nth-child(2) {
  -webkit-animation: fade 4s infinite 400ms;
  animation: fade 4s infinite 400ms;
}
.letter:nth-child(3) {
  -webkit-animation: fade 4s infinite 600ms;
  animation: fade 4s infinite 600ms;
}
.letter:nth-child(4) {
  -webkit-animation: fade 4s infinite 800ms;
  animation: fade 4s infinite 800ms;
}
.letter:nth-child(5) {
  -webkit-animation: fade 4s infinite 1000ms;
  animation: fade 4s infinite 1000ms;
}
.letter:nth-child(6) {
  -webkit-animation: fade 4s infinite 1200ms;
  animation: fade 4s infinite 1200ms;
}
.letter:nth-child(7) {
  -webkit-animation: fade 4s infinite 1400ms;
  animation: fade 4s infinite 1400ms;
}
.letter:nth-child(8) {
  -webkit-animation: fade 4s infinite 1400ms;
  animation: fade 4s infinite 1600ms;
}
.letter:nth-child(9) {
  -webkit-animation: fade 4s infinite 1400ms;
  animation: fade 4s infinite 1800ms;
}

@-webkit-keyframes fade {
  50% {
    opacity: 0.02;
  }
}
@keyframes fade {
  50% {
    opacity: 0;
  }
}
/*barra*/
.barra {
  width: 100%;
  background-color: rgba(41, 1, 1, 0.048);
  backdrop-filter: blur(15px);
  border-bottom: solid 1px rgba(255, 0, 0, 0.452);
  backdrop-filter: blur(10px);
  position: fixed;
  top: 0;
  z-index: 1;
  font-family: "Montserrat", sans-serif;
  padding: 8px;
  display: flex;
  justify-content: space-around;
  align-items: center;
  text-decoration: none;
}

/*Menu*/
.menu {
  position: relative;
  right: -50px;
}
.menu nav {
  width: 100%;
}
.menu ul {
  display: flex;
  list-style: none;
  justify-content: space-around;
  width: 100%;
}
.menu li a {
  position: relative;
  text-decoration: none;
  color: #fff;
  margin: 0 30px 0 0;
  font-size: 16px;
  transition: ease-in-out 0.3s;
  display: block;
}
.menu a:hover {
  color: #F5F5F5;
}

/*Logo*/
.logo-esquerda {
  position: relative;
  overflow: hidden;
}
.logo-esquerda img {
  width: 100% transition all linear 0.7s;
  transition-duration: 1.4s;
  width: 40px;
}
.logo-esquerda .hover-img {
  position: absolute;
  top: 0;
  left: 0;
  opacity: 0;
}

.logo-esquerda:hover img {
  opacity: 0;
}

.logo-esquerda:hover img.hover-img {
  opacity: 1;
}

/*Underline menu*/
.btn-2 {
  letter-spacing: 0;
}

.btn-2:hover,
.btn-2:active {
  letter-spacing: 2px;
}

.btn-2:after {
  content: " ";
  width: 0%;
  height: 2px;
  background-color: #f42929;
  position: absolute;
  bottom: -5px;
  left: 0;
  transition: 0.5s ease-in-out;
}

.btn-2:hover::after {
  width: 100%;
}

/*Botão contato*/
.center-botao {
  width: 126px;
  height: 42px;
  position: relative;
}

.btn {
  top: 0px;
  border-radius: 5px;
  width: 126px;
  height: 42px;
  cursor: pointer;
  background: transparent;
  border: 1px solid #fff;
  outline: none;
  transition: 1s ease-in-out;
}

svg {
  border-radius: 5px;
  position: absolute;
  left: 0;
  top: 0;
  fill: none;
  stroke: #f42929;
  stroke-dasharray: 150 480;
  stroke-dashoffset: 150;
  transition: 1s ease-in-out;
}

.btn:hover {
  transition: 1s ease-in-out;
  background: #f42929;
}

.btn:hover svg {
  stroke-dashoffset: -480;
}

.btn span {
  color: #fff;
  font-size: 18px;
  font-weight: 100;
}

main {
  width: 100%;
  min-height: 100vh;
  font-family: "Poppins", sans-serif;
  overflow-y: hidden;
}

/* background de video*/
#primeira-pagina {
  width: 100%;
  height: 100vh;
  position: relative;
}
#primeira-pagina .video-background {
  min-width: 100%;
  min-height: 100%;
  width: auto;
  height: auto;
  position: absolute;
  z-index: 0;
}
#primeira-pagina .video-background video {
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center;
  transform: translateY(-30px);
}

/*box elementos*/
.box {
  width: 50%;
  height: 100%;
  position: relative;
  display: flex;
  align-items: center;
}
.box .ocultar {
  display: none;
}
.box .cadalado {
  display: flex;
  justify-content: space-between;
  position: relative;
  top: 30px;
}

.container-pp {
  position: relative;
  text-align: center;
  flex-direction: column;
  width: 530px;
  overflow: hidden;
  color: #fff;
}
.container-pp .texto.ola {
  color: #fff;
  font-size: 30px;
}
.container-pp .texto-escrevendo {
  color: #f42929;
  font-size: 40px;
  font-weight: 600;
}

/*botão linkedin e github*/
.links-p1 {
  position: relative;
  display: flex;
  left: 1000px;
  flex-direction: column;
  transform: translateY(6px);
}
.links-p1 a {
  padding: 10px 30px;
  margin: 10px;
  border-radius: 22px;
  text-decoration: none;
}
.links-p1 .linkedin-p1 {
  box-shadow: 0 0 10px 0 #f42929 inset, 0 0 10px 4px #f42929;
  color: #fff;
  -webkit-transition: all 550ms ease-in-out;
  transition: all 550ms ease-in-out;
}
.links-p1 .github-p1 {
  box-shadow: 0 0 10px 0 #fff inset, 0 0 10px 4px #fff;
  color: #fff;
  -webkit-transition: all 550ms ease-in-out;
  transition: all 550ms ease-in-out;
}

.linkedin-p1:hover {
  border-color: #f42929;
  color: #fff;
  box-shadow: 0 0 40px 40px #f42929 inset, 0 0 0 0 #f42929;
  -webkit-transition: all 450ms ease-in-out;
  transition: all 450ms ease-in-out;
}

.github-p1:hover {
  border-color: #fff;
  color: #24252a;
  box-shadow: 0 0 40px 40px #fff inset, 0 0 0 0 #fff;
  -webkit-transition: all 450ms ease-in-out;
  transition: all 450ms ease-in-out;
}

/*# sourceMappingURL=style.cs.map */