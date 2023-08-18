"use strict";(self.webpackChunkdocument_management=self.webpackChunkdocument_management||[]).push([[823],{5823:(R,p,i)=>{i.r(p),i.d(p,{LoginModule:()=>a});var l=i(9808),f=i(2784),m=i(3075),o=i(2676),e=i(5e3),v=i(3023),A=i(2457),u=i(773),h=i(2925);function c(t,r){1&t&&(e.TgZ(0,"div",17),e._UZ(1,"mat-spinner"),e.qZA())}function k(t,r){1&t&&(e.TgZ(0,"div",20),e._uU(1),e.ALo(2,"translate"),e.qZA()),2&t&&(e.xp6(1),e.hij(" ",e.lcZ(2,1,"EMAIL_IS_REQUIRED")," "))}function E(t,r){1&t&&(e.TgZ(0,"div",20),e._uU(1),e.ALo(2,"translate"),e.qZA()),2&t&&(e.xp6(1),e.hij(" ",e.lcZ(2,1,"PLEASE_ENTER_VALID_EMAIL")," "))}function L(t,r){if(1&t&&(e.TgZ(0,"div",18),e.YNc(1,k,3,3,"div",19),e.YNc(2,E,3,3,"div",19),e.qZA()),2&t){const s=e.oxw();e.xp6(1),e.Q6J("ngIf",null==s.loginFormGroup.get("userName").errors?null:s.loginFormGroup.get("userName").errors.required),e.xp6(1),e.Q6J("ngIf",null==s.loginFormGroup.get("userName").errors?null:s.loginFormGroup.get("userName").errors.email)}}function S(t,r){1&t&&(e.TgZ(0,"div",20),e._uU(1),e.ALo(2,"translate"),e.qZA()),2&t&&(e.xp6(1),e.hij(" ",e.lcZ(2,1,"PASSWORD_IS_REQUIRED")," "))}function T(t,r){if(1&t&&(e.TgZ(0,"div",18),e.YNc(1,S,3,3,"div",19),e.qZA()),2&t){const s=e.oxw();e.xp6(1),e.Q6J("ngIf",null==s.loginFormGroup.get("password").errors?null:s.loginFormGroup.get("password").errors.required)}}const x=[{path:"",component:(()=>{class t extends o.H{constructor(s,n,d,_){super(),this.fb=s,this.router=n,this.securityService=d,this.toastr=_,this.isLoading=!1}ngOnInit(){this.createFormGroup(),navigator.geolocation.getCurrentPosition(s=>{this.lat=s.coords.latitude,this.lng=s.coords.longitude})}onLoginSubmit(){if(this.loginFormGroup.valid){this.isLoading=!0;var s=Object.assign(this.loginFormGroup.value,{latitude:this.lat,longitude:this.lng});this.sub$.sink=this.securityService.login(s).subscribe(n=>{this.isLoading=!1,this.toastr.success("User login successfully."),this.securityService.hasClaim("dashboard_view_dashboard")?this.router.navigate(["/dashboard"]):this.router.navigate(["/"])},n=>{this.isLoading=!1,n.messages.forEach(d=>{this.toastr.error(d)})})}}createFormGroup(){this.loginFormGroup=this.fb.group({userName:["",[m.kI.required,m.kI.email]],password:["",[m.kI.required]]})}onRegistrationClick(){this.router.navigate(["/registration"])}}return t.\u0275fac=function(s){return new(s||t)(e.Y36(m.QS),e.Y36(f.F0),e.Y36(v.I),e.Y36(A._W))},t.\u0275cmp=e.Xpm({type:t,selectors:[["app-login"]],features:[e.qOj],decls:30,vars:17,consts:[[1,"limiter"],[1,"container-login100"],[1,"wrap-login100"],["class","loading-shade",4,"ngIf"],[1,"login100-form","validate-form",3,"formGroup","submit"],[1,"text-center","login-logo"],["src","assets/images/login-logo.png"],[1,"login100-form-title","p-b-43"],[1,"row"],[1,"col-md-12","col-sm-12","col-12"],[1,"form-group"],["formControlName","userName","type","text",1,"form-control"],["class","k-tooltip-validation",4,"ngIf"],["type","password","formControlName","password","type","password",1,"form-control"],[1,"col-md-12","col-sm-6","col-12"],["type","submit",1,"btn-main-large",3,"disabled"],[1,"login100-more",2,"background-image","url('/assets/images/login-image.png')"],[1,"loading-shade"],[1,"k-tooltip-validation"],["class","text-danger",4,"ngIf"],[1,"text-danger"]],template:function(s,n){1&s&&(e.TgZ(0,"div",0)(1,"div",1)(2,"div",2),e.YNc(3,c,2,0,"div",3),e.TgZ(4,"form",4),e.NdJ("submit",function(){return n.onLoginSubmit()}),e.TgZ(5,"div",5),e._UZ(6,"img",6),e.qZA(),e.TgZ(7,"span",7),e._uU(8),e.ALo(9,"translate"),e.qZA(),e.TgZ(10,"div",8)(11,"div",9)(12,"div",10)(13,"label"),e._uU(14),e.ALo(15,"translate"),e.qZA(),e._UZ(16,"input",11),e.YNc(17,L,3,2,"div",12),e.qZA()(),e.TgZ(18,"div",9)(19,"div",10)(20,"label"),e._uU(21),e.ALo(22,"translate"),e.qZA(),e._UZ(23,"input",13),e.YNc(24,T,2,1,"div",12),e.qZA()(),e.TgZ(25,"div",14)(26,"button",15),e._uU(27),e.ALo(28,"translate"),e.qZA()()()(),e._UZ(29,"div",16),e.qZA()()()),2&s&&(e.xp6(3),e.Q6J("ngIf",n.isLoading),e.xp6(1),e.Q6J("formGroup",n.loginFormGroup),e.xp6(4),e.hij(" ",e.lcZ(9,9,"LOGIN_TO_CONTINUE")," "),e.xp6(6),e.Oqu(e.lcZ(15,11,"EMAIL")),e.xp6(3),e.Q6J("ngIf",n.loginFormGroup.get("userName").touched&&n.loginFormGroup.get("userName").errors),e.xp6(4),e.Oqu(e.lcZ(22,13,"PASSWORD")),e.xp6(3),e.Q6J("ngIf",n.loginFormGroup.get("password").touched&&(null==n.loginFormGroup.get("password").errors?null:n.loginFormGroup.get("password").errors.required)),e.xp6(2),e.Q6J("disabled",!n.loginFormGroup.valid),e.xp6(1),e.hij(" ",e.lcZ(28,15,"LOGIN")," "))},dependencies:[l.O5,m._Y,m.Fj,m.JJ,m.JL,m.sg,m.u,u.Ou,h.X$]}),t})()}];let C=(()=>{class t{}return t.\u0275fac=function(s){return new(s||t)},t.\u0275mod=e.oAB({type:t}),t.\u0275inj=e.cJS({imports:[f.Bz.forChild(x),f.Bz]}),t})(),a=(()=>{class t{}return t.\u0275fac=function(s){return new(s||t)},t.\u0275mod=e.oAB({type:t}),t.\u0275inj=e.cJS({imports:[l.ez,C,m.UX,u.Cq,h.aw]}),t})()},773:(R,p,i)=>{i.d(p,{Cq:()=>x,Ou:()=>g});var l=i(3191),f=i(925),m=i(9808),o=i(5e3),e=i(508),v=i(2654),A=i(9071);function u(a,t){if(1&a&&(o.O4$(),o._UZ(0,"circle",4)),2&a){const r=o.oxw(),s=o.MAs(1);o.Udp("animation-name","mat-progress-spinner-stroke-rotate-"+r._spinnerAnimationLabel)("stroke-dashoffset",r._getStrokeDashOffset(),"px")("stroke-dasharray",r._getStrokeCircumference(),"px")("stroke-width",r._getCircleStrokeWidth(),"%")("transform-origin",r._getCircleTransformOrigin(s)),o.uIk("r",r._getCircleRadius())}}function h(a,t){if(1&a&&(o.O4$(),o._UZ(0,"circle",4)),2&a){const r=o.oxw(),s=o.MAs(1);o.Udp("stroke-dashoffset",r._getStrokeDashOffset(),"px")("stroke-dasharray",r._getStrokeCircumference(),"px")("stroke-width",r._getCircleStrokeWidth(),"%")("transform-origin",r._getCircleTransformOrigin(s)),o.uIk("r",r._getCircleRadius())}}const E=(0,e.pj)(class{constructor(a){this._elementRef=a}},"primary"),L=new o.OlP("mat-progress-spinner-default-options",{providedIn:"root",factory:function S(){return{diameter:100}}});class g extends E{constructor(t,r,s,n,d,_,M,I){super(t),this._document=s,this._diameter=100,this._value=0,this._resizeSubscription=v.w.EMPTY,this.mode="determinate";const O=g._diameters;this._spinnerAnimationLabel=this._getSpinnerAnimationLabel(),O.has(s.head)||O.set(s.head,new Set([100])),this._noopAnimations="NoopAnimations"===n&&!!d&&!d._forceAnimations,"mat-spinner"===t.nativeElement.nodeName.toLowerCase()&&(this.mode="indeterminate"),d&&(d.color&&(this.color=this.defaultColor=d.color),d.diameter&&(this.diameter=d.diameter),d.strokeWidth&&(this.strokeWidth=d.strokeWidth)),r.isBrowser&&r.SAFARI&&M&&_&&I&&(this._resizeSubscription=M.change(150).subscribe(()=>{"indeterminate"===this.mode&&I.run(()=>_.markForCheck())}))}get diameter(){return this._diameter}set diameter(t){this._diameter=(0,l.su)(t),this._spinnerAnimationLabel=this._getSpinnerAnimationLabel(),this._styleRoot&&this._attachStyleNode()}get strokeWidth(){return this._strokeWidth||this.diameter/10}set strokeWidth(t){this._strokeWidth=(0,l.su)(t)}get value(){return"determinate"===this.mode?this._value:0}set value(t){this._value=Math.max(0,Math.min(100,(0,l.su)(t)))}ngOnInit(){const t=this._elementRef.nativeElement;this._styleRoot=(0,f.kV)(t)||this._document.head,this._attachStyleNode(),t.classList.add("mat-progress-spinner-indeterminate-animation")}ngOnDestroy(){this._resizeSubscription.unsubscribe()}_getCircleRadius(){return(this.diameter-10)/2}_getViewBox(){const t=2*this._getCircleRadius()+this.strokeWidth;return`0 0 ${t} ${t}`}_getStrokeCircumference(){return 2*Math.PI*this._getCircleRadius()}_getStrokeDashOffset(){return"determinate"===this.mode?this._getStrokeCircumference()*(100-this._value)/100:null}_getCircleStrokeWidth(){return this.strokeWidth/this.diameter*100}_getCircleTransformOrigin(t){var r;const s=50*(null!==(r=t.currentScale)&&void 0!==r?r:1);return`${s}% ${s}%`}_attachStyleNode(){const t=this._styleRoot,r=this._diameter,s=g._diameters;let n=s.get(t);if(!n||!n.has(r)){const d=this._document.createElement("style");d.setAttribute("mat-spinner-animation",this._spinnerAnimationLabel),d.textContent=this._getAnimationText(),t.appendChild(d),n||(n=new Set,s.set(t,n)),n.add(r)}}_getAnimationText(){const t=this._getStrokeCircumference();return"\n @keyframes mat-progress-spinner-stroke-rotate-DIAMETER {\n    0%      { stroke-dashoffset: START_VALUE;  transform: rotate(0); }\n    12.5%   { stroke-dashoffset: END_VALUE;    transform: rotate(0); }\n    12.5001%  { stroke-dashoffset: END_VALUE;    transform: rotateX(180deg) rotate(72.5deg); }\n    25%     { stroke-dashoffset: START_VALUE;  transform: rotateX(180deg) rotate(72.5deg); }\n\n    25.0001%   { stroke-dashoffset: START_VALUE;  transform: rotate(270deg); }\n    37.5%   { stroke-dashoffset: END_VALUE;    transform: rotate(270deg); }\n    37.5001%  { stroke-dashoffset: END_VALUE;    transform: rotateX(180deg) rotate(161.5deg); }\n    50%     { stroke-dashoffset: START_VALUE;  transform: rotateX(180deg) rotate(161.5deg); }\n\n    50.0001%  { stroke-dashoffset: START_VALUE;  transform: rotate(180deg); }\n    62.5%   { stroke-dashoffset: END_VALUE;    transform: rotate(180deg); }\n    62.5001%  { stroke-dashoffset: END_VALUE;    transform: rotateX(180deg) rotate(251.5deg); }\n    75%     { stroke-dashoffset: START_VALUE;  transform: rotateX(180deg) rotate(251.5deg); }\n\n    75.0001%  { stroke-dashoffset: START_VALUE;  transform: rotate(90deg); }\n    87.5%   { stroke-dashoffset: END_VALUE;    transform: rotate(90deg); }\n    87.5001%  { stroke-dashoffset: END_VALUE;    transform: rotateX(180deg) rotate(341.5deg); }\n    100%    { stroke-dashoffset: START_VALUE;  transform: rotateX(180deg) rotate(341.5deg); }\n  }\n".replace(/START_VALUE/g,""+.95*t).replace(/END_VALUE/g,""+.2*t).replace(/DIAMETER/g,`${this._spinnerAnimationLabel}`)}_getSpinnerAnimationLabel(){return this.diameter.toString().replace(".","_")}}g._diameters=new WeakMap,g.\u0275fac=function(t){return new(t||g)(o.Y36(o.SBq),o.Y36(f.t4),o.Y36(m.K0,8),o.Y36(o.QbO,8),o.Y36(L),o.Y36(o.sBO),o.Y36(A.rL),o.Y36(o.R0b))},g.\u0275cmp=o.Xpm({type:g,selectors:[["mat-progress-spinner"],["mat-spinner"]],hostAttrs:["role","progressbar","tabindex","-1",1,"mat-progress-spinner","mat-spinner"],hostVars:10,hostBindings:function(t,r){2&t&&(o.uIk("aria-valuemin","determinate"===r.mode?0:null)("aria-valuemax","determinate"===r.mode?100:null)("aria-valuenow","determinate"===r.mode?r.value:null)("mode",r.mode),o.Udp("width",r.diameter,"px")("height",r.diameter,"px"),o.ekj("_mat-animation-noopable",r._noopAnimations))},inputs:{color:"color",diameter:"diameter",strokeWidth:"strokeWidth",mode:"mode",value:"value"},exportAs:["matProgressSpinner"],features:[o.qOj],decls:4,vars:8,consts:[["preserveAspectRatio","xMidYMid meet","focusable","false","aria-hidden","true",3,"ngSwitch"],["svg",""],["cx","50%","cy","50%",3,"animation-name","stroke-dashoffset","stroke-dasharray","stroke-width","transform-origin",4,"ngSwitchCase"],["cx","50%","cy","50%",3,"stroke-dashoffset","stroke-dasharray","stroke-width","transform-origin",4,"ngSwitchCase"],["cx","50%","cy","50%"]],template:function(t,r){1&t&&(o.O4$(),o.TgZ(0,"svg",0,1),o.YNc(2,u,1,11,"circle",2),o.YNc(3,h,1,9,"circle",3),o.qZA()),2&t&&(o.Udp("width",r.diameter,"px")("height",r.diameter,"px"),o.Q6J("ngSwitch","indeterminate"===r.mode),o.uIk("viewBox",r._getViewBox()),o.xp6(2),o.Q6J("ngSwitchCase",!0),o.xp6(1),o.Q6J("ngSwitchCase",!1))},dependencies:[m.RF,m.n9],styles:[".mat-progress-spinner{display:block;position:relative;overflow:hidden}.mat-progress-spinner svg{position:absolute;transform:rotate(-90deg);top:0;left:0;transform-origin:center;overflow:visible}.mat-progress-spinner circle{fill:rgba(0,0,0,0);transition:stroke-dashoffset 225ms linear}.cdk-high-contrast-active .mat-progress-spinner circle{stroke:CanvasText}.mat-progress-spinner[mode=indeterminate] svg{animation:mat-progress-spinner-linear-rotate 2000ms linear infinite}.mat-progress-spinner[mode=indeterminate] circle{transition-property:stroke;animation-duration:4000ms;animation-timing-function:cubic-bezier(0.35, 0, 0.25, 1);animation-iteration-count:infinite}.mat-progress-spinner._mat-animation-noopable svg,.mat-progress-spinner._mat-animation-noopable circle{animation:none;transition:none}@keyframes mat-progress-spinner-linear-rotate{0%{transform:rotate(0deg)}100%{transform:rotate(360deg)}}@keyframes mat-progress-spinner-stroke-rotate-100{0%{stroke-dashoffset:268.606171575px;transform:rotate(0)}12.5%{stroke-dashoffset:56.5486677px;transform:rotate(0)}12.5001%{stroke-dashoffset:56.5486677px;transform:rotateX(180deg) rotate(72.5deg)}25%{stroke-dashoffset:268.606171575px;transform:rotateX(180deg) rotate(72.5deg)}25.0001%{stroke-dashoffset:268.606171575px;transform:rotate(270deg)}37.5%{stroke-dashoffset:56.5486677px;transform:rotate(270deg)}37.5001%{stroke-dashoffset:56.5486677px;transform:rotateX(180deg) rotate(161.5deg)}50%{stroke-dashoffset:268.606171575px;transform:rotateX(180deg) rotate(161.5deg)}50.0001%{stroke-dashoffset:268.606171575px;transform:rotate(180deg)}62.5%{stroke-dashoffset:56.5486677px;transform:rotate(180deg)}62.5001%{stroke-dashoffset:56.5486677px;transform:rotateX(180deg) rotate(251.5deg)}75%{stroke-dashoffset:268.606171575px;transform:rotateX(180deg) rotate(251.5deg)}75.0001%{stroke-dashoffset:268.606171575px;transform:rotate(90deg)}87.5%{stroke-dashoffset:56.5486677px;transform:rotate(90deg)}87.5001%{stroke-dashoffset:56.5486677px;transform:rotateX(180deg) rotate(341.5deg)}100%{stroke-dashoffset:268.606171575px;transform:rotateX(180deg) rotate(341.5deg)}}"],encapsulation:2,changeDetection:0});let x=(()=>{class a{}return a.\u0275fac=function(r){return new(r||a)},a.\u0275mod=o.oAB({type:a}),a.\u0275inj=o.cJS({imports:[e.BQ,m.ez,e.BQ]}),a})()}}]);