// -----------------------------------------------------------------------
// <copyright file="MathExtensions.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.API.Extensions
{
    using System;
    using System.Collections.Generic;

    using UnityEngine;

    /// <summary>
    /// A set of extensions for mathematical operations.
    /// </summary>
    public static class MathExtensions
    {
        /// <summary>
        /// Evaluates a probability.
        /// </summary>
        /// <param name="probability">The probability to evaluate.</param>
        /// <returns><see langword="true"/> if the probability occurred, otherwise <see langword="false"/>.</returns>
        public static bool EvaluateProbability(this int probability) => UnityEngine.Random.Range(0, 101) <= probability;

        /// <summary>
        /// Evaluates a probability.
        /// </summary>
        /// <param name="probability">The probability to evaluate.</param>
        /// <param name="minInclusive">The minimum value to include in the range.</param>
        /// <param name="maxInclusive">The maximum value to include in the range.</param>
        /// <returns><see langword="true"/> if the probability occurred, otherwise <see langword="false"/>.</returns>
        public static bool EvaluateProbability(this int probability, int minInclusive = 0, int maxInclusive = 100) => UnityEngine.Random.Range(minInclusive, ++maxInclusive) <= probability;

        /// <summary>
        /// Evaluates a probability.
        /// </summary>
        /// <param name="probability">The probability to evaluate.</param>
        /// <returns><see langword="true"/> if the probability occurred, otherwise <see langword="false"/>.</returns>
        public static bool EvaluateProbability(this float probability) => UnityEngine.Random.Range(0f, 100f) <= probability;

        /// <summary>
        /// Evaluates a probability.
        /// </summary>
        /// <param name="probability">The probability to evaluate.</param>
        /// <param name="minInclusive">The minimum value to include in the range.</param>
        /// <param name="maxInclusive">The maximum value to include in the range.</param>
        /// <returns><see langword="true"/> if the probability occurred, otherwise <see langword="false"/>.</returns>
        public static bool EvaluateProbability(this float probability, float minInclusive = 0f, float maxInclusive = 100f) => UnityEngine.Random.Range(minInclusive, maxInclusive) <= probability;
    }
}