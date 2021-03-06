Shader "WBG/ImageEffects/YUV2RGB" {
Properties {
}
SubShader {
 Tags { "QUEUE" = "Geometry" "RenderType" = "Opaque" "ShaderType" = "WBGOpaque" }
 Pass {
  Tags { "QUEUE" = "Geometry" "RenderType" = "Opaque" "ShaderType" = "WBGOpaque" }
  ZTest Always
  ZWrite Off
  Cull Off
  GpuProgramID 22852
Program "vp" {
SubProgram "gles3 hw_tier00 " {
"#ifdef VERTEX
#version 300 es

uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
uniform 	vec4 hlslcc_mtx4x4_DisplayTransform[4];
in highp vec4 in_POSITION0;
in highp vec4 in_TEXCOORD0;
out mediump vec2 vs_TEXCOORD0;
vec4 u_xlat0;
vec4 u_xlat1;
float u_xlat4;
void main()
{
    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
    u_xlat0.x = dot(hlslcc_mtx4x4_DisplayTransform[0].xy, in_TEXCOORD0.xy);
    u_xlat0.x = u_xlat0.x + hlslcc_mtx4x4_DisplayTransform[0].z;
    u_xlat4 = dot(hlslcc_mtx4x4_DisplayTransform[1].xy, in_TEXCOORD0.xy);
    u_xlat0.y = u_xlat4 + hlslcc_mtx4x4_DisplayTransform[1].z;
    vs_TEXCOORD0.xy = u_xlat0.xy;
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es

precision highp int;
uniform lowp sampler2D _TextureY;
uniform lowp sampler2D _TextureCbCr;
in mediump vec2 vs_TEXCOORD0;
layout(location = 0) out mediump vec4 SV_Target0;
vec4 u_xlat0;
vec4 u_xlat1;
void main()
{
    u_xlat0.w = 1.0;
    u_xlat1.x = texture(_TextureY, vs_TEXCOORD0.xy).x;
    u_xlat1.yz = texture(_TextureCbCr, vs_TEXCOORD0.xy).xy;
    u_xlat1.w = 1.0;
    u_xlat0.x = dot(vec3(1.0, 1.40199995, -0.700999975), u_xlat1.xzw);
    u_xlat0.y = dot(vec4(1.0, -0.344099998, -0.714100003, 0.529100001), u_xlat1);
    u_xlat0.z = dot(vec3(1.0, 1.77199996, -0.885999978), u_xlat1.xyw);
    SV_Target0 = u_xlat0;
    return;
}

#endif
"
}
SubProgram "gles3 hw_tier01 " {
"#ifdef VERTEX
#version 300 es

uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
uniform 	vec4 hlslcc_mtx4x4_DisplayTransform[4];
in highp vec4 in_POSITION0;
in highp vec4 in_TEXCOORD0;
out mediump vec2 vs_TEXCOORD0;
vec4 u_xlat0;
vec4 u_xlat1;
float u_xlat4;
void main()
{
    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
    u_xlat0.x = dot(hlslcc_mtx4x4_DisplayTransform[0].xy, in_TEXCOORD0.xy);
    u_xlat0.x = u_xlat0.x + hlslcc_mtx4x4_DisplayTransform[0].z;
    u_xlat4 = dot(hlslcc_mtx4x4_DisplayTransform[1].xy, in_TEXCOORD0.xy);
    u_xlat0.y = u_xlat4 + hlslcc_mtx4x4_DisplayTransform[1].z;
    vs_TEXCOORD0.xy = u_xlat0.xy;
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es

precision highp int;
uniform lowp sampler2D _TextureY;
uniform lowp sampler2D _TextureCbCr;
in mediump vec2 vs_TEXCOORD0;
layout(location = 0) out mediump vec4 SV_Target0;
vec4 u_xlat0;
vec4 u_xlat1;
void main()
{
    u_xlat0.w = 1.0;
    u_xlat1.x = texture(_TextureY, vs_TEXCOORD0.xy).x;
    u_xlat1.yz = texture(_TextureCbCr, vs_TEXCOORD0.xy).xy;
    u_xlat1.w = 1.0;
    u_xlat0.x = dot(vec3(1.0, 1.40199995, -0.700999975), u_xlat1.xzw);
    u_xlat0.y = dot(vec4(1.0, -0.344099998, -0.714100003, 0.529100001), u_xlat1);
    u_xlat0.z = dot(vec3(1.0, 1.77199996, -0.885999978), u_xlat1.xyw);
    SV_Target0 = u_xlat0;
    return;
}

#endif
"
}
SubProgram "gles3 hw_tier02 " {
"#ifdef VERTEX
#version 300 es

uniform 	vec4 hlslcc_mtx4x4unity_ObjectToWorld[4];
uniform 	vec4 hlslcc_mtx4x4unity_MatrixVP[4];
uniform 	vec4 hlslcc_mtx4x4_DisplayTransform[4];
in highp vec4 in_POSITION0;
in highp vec4 in_TEXCOORD0;
out mediump vec2 vs_TEXCOORD0;
vec4 u_xlat0;
vec4 u_xlat1;
float u_xlat4;
void main()
{
    u_xlat0 = in_POSITION0.yyyy * hlslcc_mtx4x4unity_ObjectToWorld[1];
    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
    u_xlat0 = hlslcc_mtx4x4unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
    u_xlat0 = u_xlat0 + hlslcc_mtx4x4unity_ObjectToWorld[3];
    u_xlat1 = u_xlat0.yyyy * hlslcc_mtx4x4unity_MatrixVP[1];
    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
    u_xlat1 = hlslcc_mtx4x4unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
    gl_Position = hlslcc_mtx4x4unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
    u_xlat0.x = dot(hlslcc_mtx4x4_DisplayTransform[0].xy, in_TEXCOORD0.xy);
    u_xlat0.x = u_xlat0.x + hlslcc_mtx4x4_DisplayTransform[0].z;
    u_xlat4 = dot(hlslcc_mtx4x4_DisplayTransform[1].xy, in_TEXCOORD0.xy);
    u_xlat0.y = u_xlat4 + hlslcc_mtx4x4_DisplayTransform[1].z;
    vs_TEXCOORD0.xy = u_xlat0.xy;
    return;
}

#endif
#ifdef FRAGMENT
#version 300 es

precision highp int;
uniform lowp sampler2D _TextureY;
uniform lowp sampler2D _TextureCbCr;
in mediump vec2 vs_TEXCOORD0;
layout(location = 0) out mediump vec4 SV_Target0;
vec4 u_xlat0;
vec4 u_xlat1;
void main()
{
    u_xlat0.w = 1.0;
    u_xlat1.x = texture(_TextureY, vs_TEXCOORD0.xy).x;
    u_xlat1.yz = texture(_TextureCbCr, vs_TEXCOORD0.xy).xy;
    u_xlat1.w = 1.0;
    u_xlat0.x = dot(vec3(1.0, 1.40199995, -0.700999975), u_xlat1.xzw);
    u_xlat0.y = dot(vec4(1.0, -0.344099998, -0.714100003, 0.529100001), u_xlat1);
    u_xlat0.z = dot(vec3(1.0, 1.77199996, -0.885999978), u_xlat1.xyw);
    SV_Target0 = u_xlat0;
    return;
}

#endif
"
}
}
Program "fp" {
SubProgram "gles3 hw_tier00 " {
""
}
SubProgram "gles3 hw_tier01 " {
""
}
SubProgram "gles3 hw_tier02 " {
""
}
}
}
}
}