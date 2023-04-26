﻿namespace PractiFly.WebApi.Dto.CourseDetails
{
    // теми курсу (відкрита тема)
    public class CourseThemeWithMaterialsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        //TODO: IsCompleted?
        public bool IsCompleted { get; set; }

        public CourseMaterialItemDto[] CourseMaterialItemDto { get; set; } = null!;
    }
}