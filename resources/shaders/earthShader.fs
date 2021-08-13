#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;
uniform sampler2D texture2;
uniform sampler2D texture3;

void main()
{
    vec4 texColor1 = texture(texture1, TexCoords);
    vec4 texColor2 = texture(texture2, TexCoords);
    vec4 texColor3 = texture(texture3, TexCoords);
    FragColor = max(texColor1, texColor2);
}